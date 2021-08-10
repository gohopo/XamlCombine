using System;

namespace XamlCombine
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourceFile = "Theme.txt";//args[0];
            var resultFile = "Theme.xaml";// args[1];
            var combiner = new Combiner();
            combiner.Combine(sourceFile, resultFile);
        }
    }
}
