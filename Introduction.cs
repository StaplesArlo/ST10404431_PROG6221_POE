#nullable disable
namespace Practice_PROG
{
    class Introduction : Styles
    {
        

        public Introduction()
        {
            Audios helloUser = new Audios(), FAQs_audio = new Audios();
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText("========================== System Initialising ==========================");
            Console.ResetColor();
            helloUser.Play("Hello.wav");

            Console.WriteLine("Please Enter Your Name:");
            name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid input. Please enter a valid name.");
                name = Console.ReadLine() ?? "";
            }

            AsciiArt.homeArt(name);
        }
    }
}