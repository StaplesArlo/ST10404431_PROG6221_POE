#nullable disable
namespace Practice_PROG
{
    class ReadQAs
    {
        private Dictionary<List<string>, string> keywordResponses = new Dictionary<List<string>, string>();
        private string path = "C:/Users/Arlo/OneDrive - ADvTECH Ltd/Documents/PROG_6221/Practice_PROG/files/";

        public ReadQAs(string file)
        {
            string filePath = Path.Combine(path, file);
            LoadResponses(filePath);
        }

        private void LoadResponses(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                List<string> keywords = null;
                string response = "";

                foreach (var line in lines)
                {
                    if (line.StartsWith("Keywords:"))
                    {
                        keywords = line.Replace("Keywords:", "").Trim().Split(", ").ToList();
                    }
                    else if (line.StartsWith("Response:") && keywords != null)
                    {
                        response = line.Replace("Response:", "").Trim();
                        keywordResponses[keywords] = response;
                    }
                }//foreach
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
                return;
            }//catch
        }//LoadResponses

        public string getResponse(string userInput)
        {
            foreach (var entry in keywordResponses)
            {
                if (entry.Key.Any(keyword => userInput.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                {
                    return entry.Value;
                }
                else if (userInput.Contains("exit", StringComparison.OrdinalIgnoreCase))
                {
                    return "Goodbye!";
                }
            }
            return "I'm not sure how to respond to that.";
           
        }//getResponse
    }//ReadQAs
}