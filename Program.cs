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
                throw new CustomException();
                throw new CustomException("This is even more customized!");
                Console.Write($"{i/j}");
                Console.Write("Out of index num?" + nums[5] + "\n");
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
        }
    }
}
