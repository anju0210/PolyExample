using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyExample
{
    class Dog : Animal
    {
        public void TestB()
        {
            Protected();
            Public();
        }

        public string Color { get; set; }

        public void Bark() { Console.WriteLine("왈왈 짓습니다."); }
    }
}
