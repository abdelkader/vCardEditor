namespace vCardEditor_Test
{
    public class JsonEntries
    {
        public static string[] JsonEmtpy
        {
            get
            {
                return "".Split('\n');
            }
        }

        public static string[] JsonIncorrect
        {
            get
            {
                return "abcdef".Split('\n');
            }
        }

        public static string JsonValid
        {
            get
            {
                return @"{
	                ""version"": ""1.0"",
	                ""languages"": {
		                ""en"": {
			                ""name"": ""English"",
			                ""messages"": {
				                ""MSG_001"": ""Save current file before?"",
				                ""MSG_002"": ""File""
			                }
		                },
		                ""fr"": {
			                ""name"": ""Français"",
			                ""messages"": {
				                ""MSG_001"": ""Sauvegarder le fichier en cours"",
				                ""MSG_002"": ""Fichier""
			                }
		                }
	                }
                }";

            }
        }

		public static string InvalidJsonValid
		{
			get
			{
				return @"{
	                ""version"": ""1.0"",
	                ""languages"": {
		                ""en"": {
			                ""name"": ""English"",
			                ""messages"": {
				                ""MSG_001"": ""Save current file before?"",
				                ""MSG_002"": ""File""
			               _002"": ""Fichier""
			                }
		                }
	                }
                }";

			}
		}
	}
}
