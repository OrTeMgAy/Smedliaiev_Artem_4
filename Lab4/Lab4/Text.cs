using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Text
    {
        protected int charactercount { get; set; }//кількість символів
        protected string name { get; set; }//сам текст
        public int number { get; set; } //номер для зручного пошуку у списках
        public Text(string name, int number)
        {             
            this.name = name;
            this.number = number;
            List<string> characters = new List<string>();
            characters = name.Split().ToList();
            charactercount = characters.Count;
        } 
        public void CharacterCount()
        {
            Console.WriteLine($"У цьому текстi {charactercount} символiв");
        }
    }
}
