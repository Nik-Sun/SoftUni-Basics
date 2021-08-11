using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int pipeA = int.Parse(Console.ReadLine());
            int pipeB = int.Parse(Console.ReadLine());
            double hoursMissing = double.Parse(Console.ReadLine());
            double pipeACont = pipeA * hoursMissing;
            double pipeBCont = pipeB * hoursMissing;
            double FlowLiters = pipeACont + pipeBCont;
            if (volume >= pipeACont + pipeBCont)
            {
                Console.WriteLine($"The pool is {(FlowLiters / volume) * 100}% full. Pipe 1: {(pipeACont / FlowLiters) * 100 :f2}%. Pipe 2: {(pipeBCont / FlowLiters) * 100 :f2}%.");
            }
            else
            {
                Console.WriteLine($"For {hoursMissing} hours the pool overflows with {Math.Abs(volume-(pipeACont+pipeBCont))} liters.");
            }
        }
    }
}
