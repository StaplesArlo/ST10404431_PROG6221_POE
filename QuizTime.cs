public class QuizTime
{
    private List<QuizQuestion> questions;
    private int score;

    public QuizTime()
    {
        questions = new List<QuizQuestion>
        {
            new QuizQuestion
            {
                Question = "What should you do if you receive an email asking for your password?",
                Options = new List<string> { "A) Reply with your password", "B) Delete the email", "C) Report the email as phishing", "D) Ignore it" },
                CorrectAnswerIndex = 2,
                Explanation = "Reporting phishing emails helps prevent scams."
            },
            new QuizQuestion
            {
                Question = "Which password is strongest?",
                Options = new List<string> { "A) 123456", "B) password123", "C) LetMeIn!", "D) 4!Tq$9mZ#c" },
                CorrectAnswerIndex = 3,
                Explanation = "Complex passwords with symbols and random characters are hardest to crack."
            },
            // Add more questions here...
        };
    }

    public void Start()
    {
        score = 0;
        Console.WriteLine("\n🎮 Welcome to the Cybersecurity Quiz!\n");

        for (int i = 0; i < questions.Count; i++)
        {
            var q = questions[i];
            Console.WriteLine($"\nQuestion {i + 1}: {q.Question}");

            for (int j = 0; j < q.Options.Count; j++)
            {
                Console.WriteLine(q.Options[j]);
            }

            Console.Write("Your answer (A-D): ");
            var userInput = Console.ReadLine()?.Trim().ToUpper();

            if (userInput == ((char)('A' + q.CorrectAnswerIndex)).ToString())
            {
                Console.WriteLine("✅ Correct!");
                score++;
            }
            else
            {
                Console.WriteLine($"❌ Incorrect. {q.Explanation}");
            }
        }

        Console.WriteLine($"\n🎓 You scored {score} out of {questions.Count}.");
        Console.WriteLine(score >= questions.Count * 0.8
            ? "Great job! You're a cybersecurity pro! 🔒"
            : "Not bad! Keep learning to stay safe online. 👨‍💻");
    }
}