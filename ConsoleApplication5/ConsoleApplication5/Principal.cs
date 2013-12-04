using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Principal
    {

          static void Main(string[] args)
        {

           Animal animal = new Animal();
            animal.Nombre = "Wailmer";
            animal.Edad = 10;
            animal.Clase = "Acuatico";
            Console.WriteLine("Los datos del Animal son:");
            animal.Imprimir();

            Console.WriteLine("------------------------------------------");

            Perro perro = new Perro();
            perro.Nombre = "BYRON";
            perro.Edad = 8;
            perro.Clase = "Canino"; 
            perro.Ladrar = "woawww!!!";
            Console.WriteLine("Los datos del Perro son:");
            perro.Imprimir();

            Console.ReadKey();
        }
    }
}
    

