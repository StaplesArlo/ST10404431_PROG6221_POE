#pragma warning disable CS8601,CS8602,CS8603,CS8604,CS8605,CS8618,CS8625,CS8632,CS8652
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;
using System.Text;

namespace POE_PROG6221
{
    class Program
    {
        static Audios helloUser = new Audios(), FAQs_audio = new Audios();
        static string question = string.Empty, reply = string.Empty;
        static void Main()
        {
          
           
            helloUser.Play("Hello.wav");
            DisplayAsciiLogo();
            getName();
            FAQs();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ask Me A Simple Question:");
            question = Console.ReadLine();
            respond(question);
            Console.WriteLine(reply);


        }//Main  

        static void getName()
        {
            string name, invalid = "Name can not be Empty.";
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine() ?? invalid;
            if (name.Equals(invalid))
            {
                Console.WriteLine(invalid);
                return;
            }
            else
            {
                Console.WriteLine($"Hello {name}, Welcome to the Cybersecurity Awareness Program!");
            }
            Console.WriteLine("----------------------------------");
        }//getName  

        static void FAQs()
        {

           
            ReadFAQsFile fileFAQs = new ReadFAQsFile();
            int num, count = fileFAQs.numAns();
            string answer;

            Console.WriteLine("Frequently Asked Questions:");

            fileFAQs.readFile("FAQs.txt");
            fileFAQs.listQuestions();
            FAQs_audio.Play("FAQs.wav");
            Console.WriteLine(value: "Please choice a question number and i will respond accordingly:");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num > 0 && num >= count)
                {
                    answer = fileFAQs.getAnswer(num);
                    Console.WriteLine($"{answer}");
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please choose a valid question number.");
                    Console.WriteLine("----------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                Console.WriteLine("----------------------------------");
            }
            return;

        }//FAQs 
        static void respond(string question)
        {
            Dictionary<string, string> responseDict = new()
    {
        { "name", "My name is CyberBot." },
        { "purpose", "I am here to assist you with cybersecurity awareness." },
        { "how", "I am doing well, thank you!" },
        { "cybersecurity", "Cybersecurity is about protecting systems and data from threats!" }
    };

            reply = "I don't have an answer for that question.";

            foreach (var keyword in responseDict.Keys)
            {
                if (question.ToLower().Contains(keyword.ToLower()))
                {
                    reply = responseDict[keyword];
                    break;
                }
            }
        }//respond

        static void DisplayAsciiLogo()
        {
            Console.WriteLine(@"
                 _________
                |  _____  |   
                | |stay | |  
                | |safe | | 
                | |_____| |  
                |_________|
               /___________\
              |_____________|  
");


        }


    }//Program
}//POE
#pragma warning restore CS8601,CS8602,CS8603,CS8604,CS8605,CS8618,CS8625,CS8632,CS8652
