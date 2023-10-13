using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during the execution

            //      try = try some code considering dangerous
            //      catch = catches and handles exception wehn occur
            //      finaly = always executes 

            double x, y, result;

            try
            {
                x = Convert.ToDouble(Console.ReadLine());

                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);

              
            }

            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers plese");

            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("you cannot divide by zero");
            }

            catch (Exception e)
            {
                Console.WriteLine("error is : " + e.ToString());
            }

            finally
            {
                Console.WriteLine("called finally");
            }


            Console.ReadKey();

        }
    }
}
