using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSorter
{
    public class ReverseSorter
    {
        public static List<Person> sort(List<Person> unsorted)
        {
            //return unsorted.OrderBy(person => person.lastName)
            //                    .ThenBy(person => person.firstNames)
            //                    .ToList();
            
            return unsorted.OrderByDescending(person => person.lastName).ThenByDescending(person => person.firstNames).ToList();
            //here laste name and surname sorted reversly


        }
    }
}
