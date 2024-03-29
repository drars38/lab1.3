﻿using System;


namespace App
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 3.В тексте удалить каждое слово с четным числом символов, продублировать каждое слово с нечетным числом символов, заменив все вхождения букв ‘d’ на букву ‘t’ . ");
            Console.WriteLine("");
            Console.WriteLine("Введите текст:");
            string inputText = Console.ReadLine();

            TextProcessor textProcessor = new TextProcessor();
            string result = textProcessor.ProcessText(inputText);

            Console.WriteLine("Результат:");
            Console.WriteLine(result);
        }
    }



    public class TextProcessor
    {
        public string ProcessText(string input)
        {
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length % 2 == 0)
                {
                    // Удалить слово с четным числом символов
                    words[i] = "";
                }
                else
                {
                    // Продублировать слово с нечетным числом символов
                    words[i] = words[i] + " " + words[i];
                    // Заменить все вхождения букв 'd' на 't'
                    words[i] = words[i].Replace('d', 't');
                }
            }

            return string.Join(" ", words);
        }
    }
}


