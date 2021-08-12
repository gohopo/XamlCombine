using System;

namespace XamlCombine
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceFile = "Theme.txt", resultFile = "Theme.xaml";
            if (args.Length == 2)
            {
                sourceFile = args[0];
                resultFile = args[1];
            }
            var combiner = new Combiner();
            combiner.Combine(sourceFile, resultFile);
        }
    }
}
