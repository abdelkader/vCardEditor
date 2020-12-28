using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vCardEditor_Test
{
    public class Entries
    {
        public static string[] vcfOneEntry
        {
            get
            {
                string s = @"BEGIN:VCARD\n" +
                        "VERSION:2.1\n" +
                        "FN:Jean Dupont1\n" +
                        "N:Dupont;Jean\n" +
                        "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                        "LABEL;QUOTED-PRINTABLE;WORK;PREF:Rue Th. Decuyper 6A=Bruxelles 1200=Belgique\n" +
                        "TEL;CELL:+1234 56789\n" +
                        "EMAIL;INTERNET:jean.dupont@example.com\n" +
                        "END:VCARD";
                return s.Split('\n');
            }
        }

        public static string[] vcfThreeEntry
        {
            get
            {
                string s = "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont1\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont1\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont3\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD";
                return s.Split('\n');
            }
        }
        public static string[] vcfUtf8Entry
        {
            get
            {
                string s = "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "N;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=41=6C=61=C3=A2;=4F=75=6D;;;\n" +
                            "FN;CHARSET=UTF-8;ENCODING=QUOTED-PRINTABLE:=4F=75=6D=20=41=6C=61=C3=A2\n" +
                            "END:VCARD";
                return s.Split('\n');
            }
        }
    }
}
