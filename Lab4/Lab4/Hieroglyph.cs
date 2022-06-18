using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Hieroglyph : Text//ієрогліф наслідує текст
    {
        private int type { get; set; }
        public Hieroglyph(int type, string name, int number) : base(name, number)
        {
            this.type = type;
            this.name = name;
        }
        public void Type()//метод визначення походження
        {
            if(type == 1)
            {
                Console.WriteLine("Ієроглiф має японське походження");
            }
            else if(type == 2)
            {
                Console.WriteLine("Ієроглiф має китайське походження");
            }
            else if(type == 3)
            {
                Console.WriteLine("Ієроглiф має корейське походження");
            }
        }
    }
}
