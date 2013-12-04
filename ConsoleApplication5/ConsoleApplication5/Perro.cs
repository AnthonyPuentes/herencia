using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
     class Perro : Animal
    {
        public string ladrar;

        public string Ladrar
        {
            set
            {
                ladrar = value;
            }
            get
            {
                return ladrar;
            }
        }

        new public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("Ladra asi: " + ladrar );
        }
    }
}
