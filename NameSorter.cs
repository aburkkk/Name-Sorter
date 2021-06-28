using System;
namespace NameSorter
{
    class NameSorter
    {
        static void Main(string[] args)
        {
            
            // Ensure exactly one argument is given
           
           if (args.Length == 2 && args[1] == "0")
            {

                var filename = args[0];
                var unsorted = Importer.importNames(filename);
                var sorted = Sorter.sort(unsorted);
                Exporter.exportNames(sorted);

            }
            else if (args.Length == 2 && args[1] == "1")
            {
               

                var filename_1 = args[0];
                var unsorted_1 = Importer.importNames(filename_1);
                var sorted_1 = ReverseSorter.sort(unsorted_1);
                Exporter.exportNames(sorted_1);
            }
            else
            {
                var filename = args[0];
                var unsorted = Importer.importNames(filename);
                var sorted = Sorter.sort(unsorted);
                Exporter.exportNames(sorted);
            }
            if (args.Length > 2 || args.Length <1)
            {
                Console.Error.WriteLine("Incorrect number of arguments entered.");
                return;
            }

        }
    }
}
