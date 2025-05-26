#nullable disable
namespace Practice_PROG
{
    class Program
    {
        static int? colourIndex;
        static void Main()
        {
            intro();
            chatbot();
        }//Main  

        static void intro()
        {
            Audios helloUser = new Audios(), FAQs_audio = new Audios();
            Console.ForegroundColor = ConsoleColor.Green;

            
            CenterText("========================== System Initialising ==========================");

            Console.ResetColor();
            helloUser.Play("Hello.wav");

            string name;
            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine() ?? "";
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input. Please enter a valid name.");
                name = Console.ReadLine() ?? "";
            }

            asciiArt(name);
           
            sectionBreak();
        }//intro

        static void chatbot()
        {
            string userInput = "question";
            CenterText("Ask Me A Simple Question:\n'exit' to close\n'home' redirect to start");

            do
            {
                if (userInput == "home")
                {
                    asciiArt("CyberSec");
                    sectionBreak();
                    CenterText("We can continue with questions if you like?\n" +
                        "'no' to close\n" +
                        "Or simply ask me something.");
                }
                ReadQAs chatbot = new ReadQAs("QAs.txt");
                userInput = Console.ReadLine();
                string response = chatbot.getResponse(userInput);
                CenterText(response);
                sectionBreak();
            } while (userInput != "exit");
        }//chatbot     


        static void asciiArt(string name)
        {

            CenterText($@"
                         ________________________________________________
                        /                                                \
                       |    _________________________________________     |
                       |   |                                         |    |
                       |   |  WELCOME:\>                             |    |
                       |   |                                         |    |
                       |   |              To CyberSec                |    |
                                             {name}                   
                       |   |                                         |    |
                       |   |                 *    *                  |    |
                       |   |                    |                    |    |
                       |   |               [        ]                |    |
                       |   |                \------/                 |    |
                       |   |                                         |    |
                       |   |                                         |    |
                       |   |            STAY SAFE ONLINE!!           |    |
                       |   |_________________________________________|    |
                       |                                                  |
                        \_________________________________________________/
                               \___________________________________/
                            ___________________________________________
                         _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
                      _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
                   _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
                _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
             _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
            :-------------------------------------------------------------------------:
            `---._.-------------------------------------------------------------._.---'
          ");



        }//asciiArt


        static void sectionBreak()
        {
            if (colourIndex == null)
            {
                colourIndex = 0;
            }
            ConsoleColor[] randomColor =
            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta,
                ConsoleColor.White,
                ConsoleColor.Blue
            };
            Console.ForegroundColor = randomColor[colourIndex.Value % randomColor.Length];
            CenterText("==========================SECTION BREAK==========================");
            Console.ResetColor();
            colourIndex++;
        }

       

        static void CenterText(string text)
        {
            int consoleWidth = Console.WindowWidth;
            int padding = (consoleWidth - text.Length) / 2;
            Console.WriteLine(text.PadLeft(padding + text.Length));
        }
    }//CLASS: Program
}//POE