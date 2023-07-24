using System;

namespace FinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.FindMaxInt(1, 2, 3);
            operation.FindMaxFloat(1.2f, 1.6f, 1.1f);
            operation.FindMaxString("a", "b", "c");
        }
    }
}
