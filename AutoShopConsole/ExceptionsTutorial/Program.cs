using ExceptionsTutorial.MyExceptions;
using System;

namespace ExceptionsTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryRunApp();
        }

        private static void RunApp()
        {
            var example = new Examples();
            var devideScore = example.TryDevide(4, 0);
            Console.WriteLine(devideScore);
        }

        private static void TryRunApp()
        {
            try
            {
                var example = new Examples();
                //var devidedScore = example.TryDevide(4, 0);
                //Console.WriteLine($"My devided soccre is: {devidedScore}");
                example.GetuserByEmail("czesssss");


            }
            catch (MyOwnException ex)
            {
                Console.WriteLine($"Throw exception with error:{ex.ErrorCode} and message: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Throw exception: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Aplikacja konczy bieg!");
            }
        }
    }
}
