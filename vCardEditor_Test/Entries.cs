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
                            "FN:Jean Dupont2\n" +
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
        public static string[] vcfFourEntry
        {
            get
            {
                string s = "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont1\n" +
                            "N:Dupont;Jean1\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
                            "TEL;CELL:+1234 56789\n" +
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont2\n" +
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
                            "EMAIL;INTERNET:jean.dupont@example.com\n" +
                            "END:VCARD\n" +
                            "BEGIN:VCARD\n" +
                            "VERSION:2.1\n" +
                            "FN:Jean Dupont4\n" +
                            "N:Dupont;Jean\n" +
                            "ADR;WORK;PREF;QUOTED-PRINTABLE:;Bruxelles 1200=Belgique;6A Rue Th. Decuyper\n" +
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

        public static string[] vcfWikiv21
        {
            get
            {
                string s = "BEGIN:VCARD" +
                            "VERSION:2.1\n" +
                            "N:Gump;Forrest;;Mr.\n" +
                            "FN:Forrest Gump\n" +
                            "ORG:Bubba Gump Shrimp Co.\n" +
                            "TITLE:Shrimp Man\n" +
                            "PHOTO;GIF:http://www.example.com/dir_photos/my_photo.gif\n" +
                            "TEL;WORK;VOICE:(111) 555-1212\n" +
                            "TEL;HOME;VOICE:(404) 555-1212\n" +
                            "ADR;WORK;PREF:;;100 Waters Edge;Baytown;LA;30314;United States of America\n" +
                            "LABEL;WORK;PREF;ENCODING=QUOTED-PRINTABLE;CHARSET=UTF-8:100 Waters Edge=0D=\n" +
                            " =0ABaytown\\, LA 30314=0D=0AUnited States of America\n" +
                            "ADR;HOME:;;42 Plantation St.;Baytown;LA;30314;United States of America\n" +
                            "LABEL;HOME;ENCODING=QUOTED-PRINTABLE;CHARSET=UTF-8:42 Plantation St.=0D=0A=\n" +
                            " Baytown, LA 30314=0D=0AUnited States of America\n" +
                            "EMAIL:forrestgump@example.com\n" +
                            "REV:20080424T195243Z\n" +
                            "END:VCARD";
                return s.Split('\n');
            }
        }
    }
}
