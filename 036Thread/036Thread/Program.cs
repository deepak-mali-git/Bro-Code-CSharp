using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _036Thread
{
    class Program
    {
        static void Main(string[] args)
        {

            // Thread = an execution path of a program
            //          we can use multiple threads to perform,
            //          different tasks of our program at the same time.
            //          Current thread runing is "main" thread
            //          using.System.Threading;

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";

            Thread thread1 = new Thread(() => CountDown("Time # 1"));
            Thread thread2 = new Thread(CountUp);

            thread1.Name = "one";
            thread2.Name = "two";

            //thread1.Start();
            //thread2.Start();

           // CountDown();
           // CountUp();

            Console.WriteLine(mainThread.Name + " is complete ");
            
            //Console.WriteLine(thread1.Name + " is complete ");
            //Console.WriteLine(thread2.Name + " is complete ");

            Console.ReadKey();


        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer #1 : " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #1 is complite!");
        }


        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer #2 : " + i + " seconds");
                Thread.Sleep(1000);
            }

            Console.WriteLine("Timer #2 is complite!");
        }



    }
}
