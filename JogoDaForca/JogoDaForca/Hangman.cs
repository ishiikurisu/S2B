using System;

namespace JogoDaForca
{
    public class Hangman
    {
        public string Word { get; private set; }
        public bool[] Answers { get; private set; }
        public const int MaximumTries = 5;
        public int NumberTries { get; private set; }
        public bool Winner { get; set; }

        public Hangman()
        {
            Word = DecideWord();
            NumberTries = MaximumTries;
            Answers = PopulateAnswers();
            Winner = false;
        }

        private bool[] PopulateAnswers()
        {
            int howMany = Word.Length;
            bool[] answers = new bool[howMany];

            for (int i = 0; i < howMany; ++i)
                answers[i] = false;

            return answers;
        }

        public bool InsertChar(char letter)
        {
            bool flag = InsertCharLoop(false, letter, 0);

            if (flag == false)
                NumberTries--;

            return flag;
        }

        private bool InsertCharLoop(bool flag, char letter, int i)
        {
            if (i == Word.Length)
                return flag;
            else if (letter == Word[i])
                return InsertCharLoop(Answers[i] = true, letter, i + 1);
            else
                return InsertCharLoop(flag, letter, i+1);
        }

        private string DecideWord()
        {
            string[] words = { "cat", "dog", "ferret", "bird", "rabbit", "horse" };
            Random rand = new Random();
            return Word = words[rand.Next(words.Length)];
        }

        public bool IsFinished()
        {
            return (IsWinner()) || (NumberTries == 0);
        }

        private bool IsWinner()
        {
            bool flag = true;

            foreach (bool answer in Answers)
                flag &= answer;

            return Winner = flag;
        }
    }
}
