using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Word : Text//слово наслідує текст
    {
        private int type { get; set; }//тип алфавіту
        public Word(int type, string name, int number) : base(name, number)
        {
            this.name = name;
            this.type = type;
        }
        public void Type()
        {
            if (type == 1)
            {
                Console.WriteLine("Латиниця");
            }
            else if (type == 2)
            {
                Console.WriteLine("Кирилиця");
            }            
        }
    }
}
