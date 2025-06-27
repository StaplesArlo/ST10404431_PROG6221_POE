using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Practice_PROG
{
    public partial class QuizWindow : Window
    {
        private class QuizQuestion
        {
            public string Question { get; set; }
            public List<string> Options { get; set; }
            public int CorrectAnswerIndex { get; set; }
            public string Explanation { get; set; }
        }

        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizWindow()
        {
            InitializeComponent();
            LoadQuestions();
            DisplayQuestion();
        }

        private void LoadQuestions()
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question = "What should you do if you receive an email asking for your password?",
                    Options = new() { "Reply with password", "Delete it", "Report it", "Ignore it" },
                    CorrectAnswerIndex = 2,
                    Explanation = "Reporting phishing emails helps prevent scams."
                },
            };
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                QuestionText.Text = $"✅ Quiz Complete! You scored {score} out of {questions.Count}.";
                FeedbackText.Text = score >= questions.Count * 0.8 ? "Great job! 🛡" : "Keep learning to stay cyber-safe!";
                return;
            }

            var q = questions[currentQuestionIndex];
            QuestionText.Text = q.Question;
            var buttons = new[] { "A", "B", "C", "D" };

            for (int i = 0; i < 4; i++)
            {
                var button = (Button)this.FindName($"Answer{i + 1}") ?? FindButton(i);
                button.Content = buttons[i] + ") " + q.Options[i];
                button.Visibility = Visibility.Visible;
            }

            FeedbackText.Text = "";
            ScoreText.Text = $"Score: {score}";
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && int.TryParse(button.Tag.ToString(), out int choice))
            {
                var q = questions[currentQuestionIndex];
                if (choice == q.CorrectAnswerIndex)
                {
                    score++;
                    FeedbackText.Text = "✅ Correct!";
                }
                else
                {
                    FeedbackText.Text = $"❌ Incorrect. {q.Explanation}";
                }

                currentQuestionIndex++;
                Dispatcher.InvokeAsync(async () =>
                {
                    await Task.Delay(1500);
                    DisplayQuestion();
                });
            }
        }

        private Button FindButton(int index) =>
            (Button)LogicalTreeHelper.FindLogicalNode(this, $"Answer{index + 1}");
    }
}