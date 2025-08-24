using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public string[] Options { get; set; }
    public char Answer { get; set; }
}

class QuizApplication
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question
            {
                Text = "What is the capital of India?",
                Options = new string[] {"A. Berlin", "B. Madrid", "C. New Delhi", "D. Rome"},
                Answer = 'C'
            },
            new Question
            {
                Text = "Which language is used for .NET development?",
                Options = new string[] {"A. Python", "B. C#", "C. Java", "D. C"},
                Answer = 'B'
            },
            new Question
            {
                Text = "Which planet is known as the Red Planet?",
                Options = new string[] {"A. Earth", "B. Mars", "C. Venus", "D. Jupiter"},
                Answer = 'B'
            },
            new Question
            {
                Text = "Who wrote the National Anthem of India?",
                Options = new string[] { "A. Rabindranath Tagore", "B. Bankim Chandra Chattopadhyay", "C. Sarojini Naidu", "D. Mahatma Gandhi"},
                Answer = 'A'
            },
            new Question
            {
                Text = "In which year did India get independence?",
                Options = new string[] {"A. 1942", "B. 1947", "C. 1950", "D. 1957"},
                Answer = 'B'
            },
            new Question
            {
                Text = "Who is known as the Father of Computers?",
                Options = new string[] { "A. Steve Jobs", "B. Alan Turing", "C. Bill Gates", "D. Charles Babbage"},
                Answer = 'D'
            },
            new Question
            {
                Text = "Which country is known as the Land of the Rising Sun?",
                Options = new string[] { "A. India", "B. China", "C. Japan", "D. Thailand"},
                Answer = 'C'
            },
            new Question
            {
                Text = "Which sport is known as the 'king of sports'?",
                Options = new string[] { "A. Cricket", "B. Tennis", "C. Hockey", "D. Football (Soccer)"},
                Answer = 'D'
            },
            new Question
            {
                Text = "Which blood group is known as the universal donor?",
                Options = new string[] { "A. O-", "B. AB+", "C. O+", "D. A-"},
                Answer = 'A'
            },
            new Question
            {
                Text = "Which Indian city is called the Pink City?",
                Options = new string[] { "A. Udaipur", "B. Jodhpur", "C. Jaipur", "D. Agra"},
                Answer = 'C'
            },
        };

        int score = 0;

        Console.WriteLine("===== Welcome to the Quiz Application =====\n");

        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"Q{i + 1}. {questions[i].Text}");
            foreach (var option in questions[i].Options)
            {
                Console.WriteLine(option);
            }

            Console.Write("Your answer (A/B/C/D): ");
            char userAnswer = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (userAnswer == questions[i].Answer)
            {
                Console.WriteLine("✅ Correct!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"❌ Wrong! Correct Answer: {questions[i].Answer}\n");
            }
        }

        Console.WriteLine("===== Quiz Finished =====");
        Console.WriteLine($"Your Score: {score}/{questions.Count}");

        if (score == questions.Count)
            Console.WriteLine("*** Excellent! Perfect score!");
        else if (score >= questions.Count / 2)
            Console.WriteLine("** Good job, keep practicing!");
        else
            Console.WriteLine("* Better luck next time!");
    }
}
