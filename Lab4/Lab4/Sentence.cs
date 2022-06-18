using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Sentence : Word//речення наслідує слово бо у слова є характеристика типу алфавіту
                                  //а у слова нема характеристики кількості слів у ньорму
    {
        List<string> words = new List<string>();//список для обчислення кількості слів 
        private int wordscount { get; set; }
        public Sentence(string name, int type, int number) : base(type, name, number)
        {
            this.name = name;
            words = name.Split(' ').ToList();
            wordscount = words.Count;
        }
        public void WordCount()
        {
            Console.WriteLine($"У цьому реченнi {wordscount} слiв");
        }
    }
}
