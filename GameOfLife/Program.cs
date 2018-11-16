using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int GridSize = 1000;
            int Iterations = 100;

            GameOfLife gol = new GameOfLife(GridSize);
            GameOfLifeParallel golP = new GameOfLifeParallel(GridSize);
            GameOfLifeParallelTaskBarrier golPTB = new GameOfLifeParallelTaskBarrier(GridSize);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            
            //gol.Run(Iterations);
            //golP.Run(Iterations);
            golPTB.Run(Iterations);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine($"Execution time {elapsedMs}ms");
            Console.ReadKey();
        }
    }
}
