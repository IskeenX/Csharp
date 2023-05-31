using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlng
{
    internal class UI
    {
        Logc compLogic = new Logc(); 

        private void GetInput(out int x, out int y, out char o)
        {
            Console.Write("Number #1: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Number #2: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Operation: ");
            o = char.Parse(Console.ReadLine());
        }
        private int DoComputation(int x, int y, char o)
        {
            int result = 0;   
            if(o == '+')
            {
                result = compLogic.Add(x,y);
                return result;
            }
            else if(o == '/')
            {
                result = compLogic.Divide(x,y);
                return result;
            }
            else
            {
                throw new UnknownOperatorException();
            }
        }
        public void Run()
        {
            int x;
            int y;
            char o;
            try
            {
                GetInput(out x, out y, out o);
                int result = DoComputation(x, y, o);
                Console.WriteLine($"{x} {o} {y} = {result}");
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stupid!");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Write a number!");
                Console.ResetColor();
            }
            catch (OverflowException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Too large!");
                Console.ResetColor();
                x = int.MaxValue;
                y = int.MaxValue;
            }
            catch (UnknownOperatorException e)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"At {e.TimeStamp}");
                Console.ResetColor();
            }
        }
    }
}