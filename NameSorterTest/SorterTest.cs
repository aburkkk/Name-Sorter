using System;
using System.Collections.Generic;
using NameSorter;
using Xunit;

namespace NameSorterTest
{
    public class SortTester
    {
        [Fact]
        public void simpleSortTest()
        {
            var firstNames = new List<string> {
                "Janet",
                "Vaughn",
                "Adonis Julius",
                "Shelby Nathan",
                "Marin",
                "London",
                "Beau Tristan",
                "Leo",
                "Hunter Uriah Mathew",
                "Mikayla",
                "Frankie Conner"
            };
            var lastNames = new List<string> {
                "Parsons",
                "Lewis",
                "Archer",
                "Yoder",
                "Alvarez",
                "Lindsey",
                "Bentley",
                "Gardner",
                "Clarke",
                "Lopez",
                "Ritter"
            };
            var unsorted = personListMaker(firstNames, lastNames);
            var testSorted = Sorter.sort(unsorted);

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
            Assert.Equal(correctSorted, testSorted);
        }

        [Fact]
        public void sameLastTester()
        {
            var unsortedFirst = new List<string> {
                "Lisa",
                "Tony",
                "Keun Young",
                "John",
                "Michael",
                "Mai",
                "Michelle"
            };
            var unsortedLast = new List<string> {
                "Smith",
                "Nguyen",
                "Kim",
                "Smith",
                "Kim",
                "Nguyen",
                "Nguyen"
            };
            var sortedFirst = new List<string> {
                "Keun Young",
                "Michael",
                "Mai",
                "Michelle",
                "Tony",
                "John",
                "Lisa"
            };
            var sortedLast = new List<string> {
                "Kim",
                "Kim",
                "Nguyen",
                "Nguyen",
                "Nguyen",
                "Smith",
                "Smith"
            };
            var unsorted = personListMaker(unsortedFirst, unsortedLast);
            var testSorted = Sorter.sort(unsorted);
            var correctSorted = personListMaker(sortedFirst, sortedLast);
            Assert.Equal(correctSorted, testSorted);
        }

        [Fact]
        public void sameFirstTester()
        {
            var unsortedFirst = new List<string> {
                "Richard",
                "Johann Senior",
                "Ludwig van",
                "Johann Sebastian",
                "Gustav",
                "Johann Junior",
                "Richard",
                "Gustav"
            };
            var unsortedLast = new List<string> {
                "Strauss",
                "Strauss",
                "Beethoven",
                "Bach",
                "Holst",
                "Strauss",
                "Wagner",
                "Mahler"
            };
            var sortedFirst = new List<string> {
                "Johann Sebastian",
                "Ludwig van",
                "Gustav",
                "Gustav",
                "Johann Junior",
                "Johann Senior",
                "Richard",
                "Richard"
            };
            var sortedLast = new List<string> {
                "Bach",
                "Beethoven",
                "Holst",
                "Mahler",
                "Strauss",
                "Strauss",
                "Strauss",
                "Wagner"
            };
            var unsorted = personListMaker(unsortedFirst, unsortedLast);
            var testSorted = Sorter.sort(unsorted);
            var correctSorted = personListMaker(sortedFirst, sortedLast);
            Assert.Equal(correctSorted, testSorted);
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
    }
}
