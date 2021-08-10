using System;

namespace XamlCombine
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFile = args[0];
            var resultFile = args[1];
            var combiner = new Combiner();
            combiner.Combine(sourceFile, resultFile);
        }
    }
}
