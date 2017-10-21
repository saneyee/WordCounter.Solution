using System;
using System.Collections.Generic;



namespace WordCounter
{
    public class RepeatCounter
    {
        private string _InputSentence;
        private string _InputWord;

        public RepeatCounter(string InputSentence, string InputWord)
        {
            _InputSentence = InputSentence.ToUpper();
            _InputWord = InputWord.ToUpper();
        }

        public int CountRepeats()
        {
            int Count = 0;
            string[] SplitInputSentence = _InputSentence.Split();

            for (int i=0; i < SplitInputSentence.Length; i++)
            {
                if (SplitInputSentence[i] == _InputWord)
                {
                    Count += 1;
                }
            }
            return Count;
        }

    }
}
