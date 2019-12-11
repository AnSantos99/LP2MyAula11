using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia de MyVector que aceita dois parametros
            MyVector v = new MyVector(3, 5.5f);

            // Indixando valores ao index do nosso index da struct
            // myStruct
            v[1] = 3.4f;
            v[0] = -266;

            //Escrever resultados na consola
            Console.WriteLine($"{v[0]} ou {v.Y}");
        }
    }
}
