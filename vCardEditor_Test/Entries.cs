namespace vCardEditor_Test
{
    public class Entries
    {
        public static string[] vcfEmtpy
        {
            get
            {
                return "".Split('\n');
            }
        }

        public static string[] vcfIncorrect
        {
            get
            {
                return "abcdef".Split('\n');
            }
        }

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

        public static string[] vcfwithExternalPhoto
        {
            get
            {
                string s = @"BEGIN:VCARD
                            VERSION:4.0
                            N:Gump;Forrest;;;
                            FN:Forrest Gump
                            ORG:Bubba Gump Shrimp Co.
                            TITLE:Shrimp Man
                            PHOTO;MEDIATYPE=image/jpg:https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/TomHanksForrestGump94.jpg/224px-TomHanksForrestGump94.jpg
                            TEL;TYPE=work,voice;VALUE=uri:tel:+1-111-555-1212
                            TEL;TYPE=home,voice;VALUE=uri:tel:+1-404-555-1212
                            ADR;TYPE=work;LABEL=""100 Waters Edge\nBaytown, LA 30314\nUnited States of America""
                              :;;100 Waters Edge; Baytown;LA;30314;United States of America
                            ADR;TYPE=home;LABEL=""42 Plantation St.\nBaytown, LA 30314\nUnited States of America""
                             :;;42 Plantation St.; Baytown;LA;30314;United States of America
                            EMAIL:forrestgump @example.com
                            REV:20080424T195243Z
                            END:VCARD";
                return s.Split('\n');
            }
        }

        public static string[] vcfwithInternalPhoto
        {
            get
            {
                string s = @"BEGIN:VCARD
                            VERSION:3.0
                            N:Dupont;Jean;;;
                            FN:Jean Dupont1
                            ADR;TYPE=WORK;TYPE=PREF:;;6A Rue Th. Decuyper;;;;
                            EMAIL;TYPE=INTERNET:jean.dupont@example.com
                            PHOTO;ENCODING=b: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
                            TEL;TYPE=CELL:+1234 56789
                            END:VCARD";
                return s.Split('\n');
            }

        }

    }
}
