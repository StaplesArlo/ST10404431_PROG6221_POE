#nullable disable
namespace Practice_PROG
{
    class Chatbot : Styles
    {
        public Chatbot()
        {
            string userInput = "question";
            CenterText("Ask Me A Simple Question:\n'exit' to close\n'home' redirect to start");

            do
            {
                if (userInput == "home")
                {
                  
                    sectionBreak();
                    CenterText("Okay," + name + " We can continue with questions if you like?\n" +
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
    }
}
