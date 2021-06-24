using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class Sorter
    {
        public static List<Person> sort(List<Person> unsorted)
        {
            return unsorted.OrderBy(person => person.lastName)
                                 .ThenBy(person => person.firstNames)
                                 .ToList();
        }
    }
}
