using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(FrogRace);

            Thread t2 = new Thread(FrogRace);

            Thread t3 = new Thread(FrogRace);

            t1.Start(1);
            t2.Start(2);
            t3.Start(3);

            t1.Join(1);
            t2.Join(2);
            t3.Join(3);
        }

        public static void FrogRace(object obj) 
        {
            

            int id = (int)obj;
            Random rnd = new Random(id);

            for (int i = 0; i < 10; i++) 
            {
                Thread.Sleep(rnd.Next(1000));
                Console.WriteLine($"Rã #{id} deu salto #{i + 1}");
                
            }
        }
    }
}
