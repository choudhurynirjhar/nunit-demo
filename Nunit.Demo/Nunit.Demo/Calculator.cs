using System;

namespace Nunit.Demo
{
    public class Calculator : IDisposable
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }

        public void Dispose()
        {
            // todo
        }

        public int Substraction(int first, int second)
        {
            if (first < second)
                throw new ArgumentException($"First number {first} is less than second number {second}");

            return first - second;
        }
    }
}
