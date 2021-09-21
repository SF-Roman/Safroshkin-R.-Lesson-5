using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
   
    static class Message
    {
        static public string str;

        static Message()
        {
            str = "Повседневная практика показывает, что экономическая повестка сегодняшнего дня позволяет оценить \n" +
                "значение вывода текущих активов. Прежде всего, перспективное планирование обеспечивает актуальность поставленных обществом задач. \n" +
                "Высокий уровень вовлечения представителей целевой аудитории является четким доказательством простого факта: понимание сути ресурсосберегающих \n" +
                "технологий обеспечивает актуальность глубокомысленных рассуждений.\n";
        }
        static public void GetLenWords_n_Len(int len)
        {
            string[] words = str.Split(new Char[] { '\n', '\t', ',', '.', '-', ' ', ':' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word.Length <= len)
                    Console.Write(word + " ");
            }
        }
        static public void Del_Words(char let)
        {
            string[] words = str.Split(new Char[] { '\n', '\t', ',', '.', '-', ' ', ':' });
            foreach (string word in words)
            {
                if (word == "")
                    continue;
                if (word[word.Length - 1] == let)
                {
                    Console.Write(word + " ");
                    str.Replace(word, "");
                }
            }
        }
        static public string MaxLen_Word()
        {
            string[] words = str.Split(new Char[] { '\n', '\t', ',', '.', '-', ' ', ':' });
            string maxWord = words[0];
            int max = words[0].Length;

            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    maxWord = word;
                }
            }
            return maxWord;
        }

        static public StringBuilder Form_String_LongWords()
        {
            string[] words = str.Split(new Char[] { '\n', '\t', ',', '.', '-', ' ', ':' });
            StringBuilder result = new StringBuilder();
            int max = Message.MaxLen_Word().Length;
            foreach (string word in words)
            {
                if (word.Length == max)
                {
                    result.Append(word.ToLower() + " ");
                }
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nТекст для проведения операций: \n" + Message.str);
            Console.WriteLine();

            Console.WriteLine("\nСлова, в которых не более шести букв: ");
            Message.GetLenWords_n_Len(6);
            Console.WriteLine();

            Console.WriteLine("\nУдаление слов, заканчивающихся на букву 'т': ");
            Message.Del_Words('т');
            Console.WriteLine();

            Console.WriteLine("\nСамое длинное слово в тексте: \n" + Message.MaxLen_Word());

            Console.WriteLine("\nСтрока из самых длинных слов текста: \n" + Message.Form_String_LongWords());


            Console.ReadKey();

        }
    }
}
