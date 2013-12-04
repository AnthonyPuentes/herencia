using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{

    public class Animal
    {
        string nombre;
        string clase;
        int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }


        public int Edad
        {

            set
            {
                edad = value;
            }
            get
            {
                return edad;

            }
        }


        public string Clase
        {


            set
            {
                clase = value;

            }
            get
            {

                return clase;
            }

        }
        public void Imprimir()
        {


            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Edad: " + Edad);
            Console.WriteLine("Clase: " + Clase);
        }
    }
}



