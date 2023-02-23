namespace C_Sharp
{
    internal class Program
    {
        static void Output(params object[] list)
        {
            foreach (object el in list)
            {
                if (el is string || el is int)
                    Console.WriteLine(el);

                if (el is int[])
                    foreach (int i in (int[])el)
                        Console.WriteLine(i);
            }
        }

        static void Main()
        {
            Output(
                _1TwoSum.TwoSum(new int[] { 2, 7, 11, 15 }, 9)
            );
        }
    }
}