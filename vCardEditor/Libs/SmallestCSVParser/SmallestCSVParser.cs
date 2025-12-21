using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

// SmallestCSVParser version 1.2.0 - Copyright (C) 2024-2025 Karl Pickett
namespace vCardEditor.Libs.SmallestCSVParser
{
    public class SmallestCSVParser
    {
        /// <summary>
        /// This is thrown if the CSV has invalid syntax.
        /// </summary>
        public class Error : Exception
        {
            public Error(string message) : base(message) { }
        }

        /// <summary>
        /// This class does not Close/Dispose the `stream`.
        /// </summary>
        public SmallestCSVParser(StreamReader stream)
        {
            _stream = stream;
            _sb = new StringBuilder();
        }

        /// <summary>
        /// Read all columns for the next row/line.
        /// If we are at end of file, this returns null.
        ///
        /// By default, columns that were quoted (") have their enclosing quotes
        /// removed.  Set `removeEnclosingQuotes` to false if you want to preserve
        /// the quotes, for example to distinguish between an empty quoted vs
        /// unquoted column.
        /// </summary>
        public List<string> ReadNextRow(bool removeEnclosingQuotes = true)
        {
            List<string> ret = new List<string>();
            while (true)
            {
                var (column, hasMore) = ReadNextColumn(removeEnclosingQuotes);
                if (column != null)
                {
                    ret.Add(column);
                }
                if (!hasMore)
                {
                    return ret.Any() ? ret : null;
                }
            }
        }

        private (string Column, bool RowHasMoreColumns) ReadNextColumn(bool removeEnclosingQuotes)
        {
            _sb.Clear();
            switch (_stream.Peek())
            {
                case -1:
                    return (null, false);
                case '"':
                    ReadQuotedColumn(removeEnclosingQuotes);
                    return (_sb.ToString(), !TryFinishLine());
                default:
                    ReadNonQuotedColumn();
                    return (_sb.ToString(), !TryFinishLine());
            }
        }

        // A quoted column ends with a non-escaped quote (").
        private void ReadQuotedColumn(bool removeEnclosingQuotes)
        {
            _stream.Read();  // Remove the quote from the stream
            if (!removeEnclosingQuotes)
            {
                _sb.Append('"');  // Optionally keep the quote in the result
            }
            while (true)
            {
                int ch = _stream.Read();
                switch (ch)
                {
                    case -1:
                        throw new Error("EOF reached inside quoted column");
                    case '"':
                        if (_stream.Peek() == '"')
                        {
                            // A "" is an escaped ". Keep it and continue.
                            _stream.Read();
                            _sb.Append('"');
                            break;
                        }
                        else
                        {
                            // A non-escaped ". We're done with this column.
                            if (!removeEnclosingQuotes)
                            {
                                _sb.Append('"');  // Optionally keep the quote in the result
                            }
                            return;
                        }
                    default:
                        _sb.Append((char)ch);
                        break;
                }
            }
        }

        // A non-quoted column ends with a newline, comma, or EOF.
        private void ReadNonQuotedColumn()
        {
            while (true)
            {
                int ch = _stream.Peek();
                if (ch == -1 || ch == '\r' || ch == '\n' || ch == ',')
                {
                    // We aren't consuming the '\r' here. A later call to ReadWithNormalizedNewline will consume it.
                    return;
                }
                _stream.Read();
                _sb.Append((char)ch);
            }
        }

        // Consume and return the next char from the stream, or return EOF.
        // Maps ('\r', '\n', '\r\n') -> '\n'.
        private int ReadWithNormalizedNewline()
        {
            int ret = _stream.Read();
            if (ret == '\r')
            {
                if (_stream.Peek() == '\n')
                {
                    _stream.Read();
                }
                ret = '\n';
            }
            return ret;
        }

        private bool TryFinishLine()
        {
            int ch = ReadWithNormalizedNewline();
            switch (ch)
            {
                case -1:
                case '\n':
                    return true;  // All columns parsed for this row/line
                case ',':
                    return false; // More columns remain for this row/line
                default:
                    throw new Error($"Unrecognized character '{(char)ch}' after a parsed column");
            }
        }

        private readonly StreamReader _stream;
        private readonly StringBuilder _sb;
    }
}
