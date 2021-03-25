using System;
using System.Collections.Generic;

namespace collection
{   
    class Word
    {
        public Word(string text_)
        {
            text = text_;
        }
        public int counter = 1;
        public string text = ""; 
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "I need food, food is my life! Life bad without food, i love food.";
            //Console.WriteLine(WordFrequency(text));
            
            List<Word> list = WordFrequency(text);
        }

        static List<Word> WordFrequency(string text)
        {   
            string tempText = "";
            string[] massText;
            
            int counter = 0;
            
            List<Word> list = new List<Word>();
            
            text = text.ToLower();
            massText = text.Split(" ");
            
            
            foreach (string element in massText)
            {
                tempText = "";
                
                for (int i = 0; i < element.Length; i++)
                    if (Char.IsLetter(element, i))
                        tempText += element[i];

                massText[counter] = tempText;
                counter++;
            }
            
            bool check = false;
            foreach (string element in massText)
            {   
                check = false;
                foreach (Word wordElement in list)
                {
                    if (wordElement.text == element)
                    {
                        wordElement.counter++;
                        check = true;
                    }
                }
                if (!check)
                    list.Add(new Word(element));
            }
            return list;
        }
    }
}
