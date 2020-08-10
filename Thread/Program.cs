using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Media;

namespace Thread1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Task myTask = Task.Factory.StartNew(Berechnen);


            /*Task myTask = new Task(Berechnen);
            myTask.Start();*/

            Thread t1 = new Thread(Berechnen1);  // Um Worker Thread (Parallel Thread) zu erzuegen, dass es 
            t1.Name = "t1";
            t1.Start();

            Thread t2 = new Thread(Berechnen2);
            t2.Name = "t2";
            t2.Start();

            Thread t3 = new Thread(Berechnen3);
            t3.Name = "t3";
            t3.Start();

            /* string str = "Hallo World";
             Console.WriteLine("some test {0}", str);*/

            Console.ReadKey();
        }
        //------------------------------------------------------

        public static void Berechnen1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(2000);

                Console.WriteLine("x");
                //Debug.WriteLine("Thread1 arbeitet {0}",i);
                Debug.Print("Thread {0}", Thread.CurrentThread.Name);
            }
        }


        public static void Berechnen2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(2000);

                Console.WriteLine("y");
                // Debug.WriteLine("Thread3 arbeitet {0}", i);
                Debug.Print("Thread {0}", Thread.CurrentThread.Name);
            }
        }


        public static void Berechnen3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(2000);

                Console.WriteLine("y");
                // Debug.WriteLine("Thread2 arbeitet {0}", i);
                Debug.Print("Thread {0}", Thread.CurrentThread.Name);
            }
        }


    }
}
