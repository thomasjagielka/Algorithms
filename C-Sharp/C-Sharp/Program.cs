namespace C_Sharp
{
    internal class Program
    {
        static void Output(params object[] list)
        {
            foreach (object el in list)
            {
                if (el is string || el is int || el is bool)
                    Console.WriteLine(el);

                if (el is int[])
                    foreach (int i in (int[])el)
                        Console.WriteLine(i);
            }
        }

        static void Main()
        {
            Output(
                 _724FindPivotIndex.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 })
            ); ;
        }
    }
}