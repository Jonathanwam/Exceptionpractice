using System;

namespace exceptionpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 0;
            int[] nums = new int[3]{1,2,3};
            try
            {
                // throw new CustomException(); // making custom exceptions
                // throw new CustomException("This is even more customized!");
                // Console.Write($"{i/j}"); // can't divide by zero exception
                // Console.Write("Out of index num?" + nums[5] + "\n"); // dealing with out of index exception
                A(); // example of trycatch hierarchy
                Console.Write("Main method after calling A() method\n");
            }
            catch (DivideByZeroException ex)
            {
                Console.Write("You can't divide by zero... " + ex + "\n");
            }
            catch (Exception ex)
            {
                Console.Write("Got this more generic exception... " + ex + "\n");
            }
            finally
            {
                Console.Write("Finally! \n");
            }

            Console.Write("Out of the try-catch");


            void A() {
                try
                {
                    B();
                }
                catch (Exception ex)
                {
                    Console.Write($"Caught error within A() method: {ex}\n");
                }
                Console.Write("Test A\n");
            }
            void B() {
                C();
                Console.Write("test B\n"); // should not run this line
            }
            void C() {
                throw new Exception("error\n");
            }
        }
    }
}
