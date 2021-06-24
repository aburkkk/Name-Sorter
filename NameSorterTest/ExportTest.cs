using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using NameSorter;
using System.IO;
using System.Security.Cryptography;

namespace NameSorterTest
{
    public class ExportTest
    {
        [Fact]
        public void simpleOutputTest()
        {
            var sortedFirstNames = new List<string> {
                "Marin",
                "Adonis Julius",
                "Beau Tristan",
                "Hunter Uriah Mathew",
                "Leo",
                "Vaughn",
                "London",
                "Mikayla",
                "Janet",
                "Frankie Conner",
                "Shelby Nathan"
            };
            var sortedLastNames = new List<string> {
                "Alvarez",
                "Archer",
                "Bentley",
                "Clarke",
                "Gardner",
                "Lewis",
                "Lindsey",
                "Lopez",
                "Parsons",
                "Ritter",
                "Yoder"
            };
            var correctSorted = personListMaker(sortedFirstNames, sortedLastNames);
            Exporter.exportNames(correctSorted);
            checkEqual("../../../answers/simple-names.txt", "sorted-names-list.txt");
        }

        private List<Person> personListMaker(List<string> firstNames, List<string> lastNames)
        {
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            return people;
        }

        private void checkEqual(string pathOne, string pathTwo)
        {
            byte[] hashOne;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(pathOne))
                {
                    hashOne = md5.ComputeHash(stream);
                }
            }
            byte[] hashTwo;
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(pathTwo))
                {
                    hashTwo = md5.ComputeHash(stream);
                }
            }
            Assert.True(hashOne.SequenceEqual(hashTwo));
        }
    }
}
