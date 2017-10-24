using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data type : Byte");
            Console.WriteLine("Size :" + sizeof(Byte));
            Console.WriteLine("Minimum Value :" + Byte.MinValue);
            Console.WriteLine("Maximum Value :" + Byte.MaxValue);
        }
    }
}
