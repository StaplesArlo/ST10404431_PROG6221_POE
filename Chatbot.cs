using Practice_PROG;
using System.Xml.Linq;
using System.Windows;

class Chatbot : Styles
{
    private List<ActivityLog> log = new List<ActivityLog>();

    public Chatbot()
    {
        string userInput = "question", response;
        CenterText("Ask Me A Simple Question:\n'exit' to close\n'home' redirect to start");

        //ReadTxts emotion = new ReadTxts("Emote.txt");
        ReadTxts cybersec = new ReadTxts("QAs.txt");
        TipManager tipManager = new TipManager("Tips.txt");

        do
        {
            if (userInput == "home")
            {
                sectionBreak();
                CenterText("Okay," + name + " We can continue with questions if you like?\n" +
                    "'no' to close\n" +
                    "Or simply ask me something.");
                Log("Returned to home section.");
            }
            else if (userInput == "no")
            {
                CenterText("Okay, " + name + ", I will see you later.");
                Log("User chose to exit with 'no'.");
                break;
            }
            else if (userInput.Contains("tip"))
            {
                sectionBreak();
                CenterText("Here are some tips to help you:");
                Log("User requested a tip.");      
                string tip = tipManager.GetRandomTip();
                CenterText(tip);
                Log("Displayed a random tip: " + tip);
                sectionBreak();
            }
            else if (userInput == "exit")
            {
                CenterText("Goodbye!");
                Log("Exited chatbot.");
                break;
            }
            else if (userInput == "show activity log" || userInput == "what have you done for me")
            {
                DisplayLog();
                sectionBreak();
            }
            else if (userInput.Contains("quiz"))
            {
                QuizTime quiz = new QuizTime();
                quiz.Start();
                QuizWindow quizWindow = new QuizWindow();
                quizWindow.ShowDialog();
                Log("User started the Cybersecurity Quiz.");
            }

            userInput = Console.ReadLine()?.Trim().ToLower() ?? "";
            response = cybersec.getResponse(userInput);//emotion.getResponse(userInput) + //
            CenterText(response);
            Log("Responded to: '" + userInput + "'");
            sectionBreak();

        } while (userInput != "exit");
    }

    private void Log(string description)
    {
        log.Add(new ActivityLog { Timestamp = DateTime.Now, Description = description });
        if (log.Count > 100)
            log.RemoveAt(0);
    }

    private void DisplayLog()
    {
        CenterText("Here's a summary of recent activity:");
        int count = 1;
        foreach (var entry in log.TakeLast(10))
        {
            Console.WriteLine($"{count++}. {entry}");
        }
    }
}