using System.Collections;

namespace POE_PROG6221
{
    public class ReadFAQsFile
    {
        private string path = "C:/Users/Arlo/OneDrive - ADvTECH Ltd/Documents/PROG_6221/POE_PROG6221/files/";
        private ArrayList Questions = new ArrayList();
        private ArrayList Answers = new ArrayList();


        public void readFile(string file)
        {
            string filePath = Path.Combine(path, file);
            try
            {
                string question = string.Empty,
                answer = string.Empty;
                foreach (string line in File.ReadLines(filePath))
                {
                    //LINE: Starts with "Q-" = question
                    if (line.StartsWith("Question: "))
                    {
                        //REMOVE: "Q-" from line
                        question = line;
                        //ADD: question to Questions
                        Questions.Add(question);
                    }
                    //OR LINE: Starts w/ "A-" = answer
                    else if (line.StartsWith("Answer: "))
                    {
                        answer = line;
                        //ADD: answer to Answers
                        Answers.Add(answer);
                    }//elseif     
                }//foreach


            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }//catch
        }//ReadQuestions

        public void listQuestions()
        {
            for (int x = 0; x < Questions.Count; x++)
            {
                Console.WriteLine($" {x + 1}. {Questions[x]}");
            }
        }//listQuestions
        public String getAnswer(int num)
        {
            return (string)Answers[num - 1];
        }//getAnswer
        public int numQu()
        {
            return Questions.Count;
        }//numQu
        public int numAns()
        {
            return Answers.Count;
        }//numAns


    }//QuestionFiles
}