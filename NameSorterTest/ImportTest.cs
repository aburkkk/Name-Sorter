using System;
using System.Collections.Generic;
using Xunit;
using NameSorter;

namespace NameSorterTest
{
    public class ImportTester
    {
        [Fact]
        public void basicReadTest()
        {
            var firstNames = new List<String> {
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
            var lastNames = new List<String> {
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
            var people = new List<Person> { };
            for (int i = 0; i < firstNames.Count; ++i)
            {
                people.Add(new Person(firstNames[i], lastNames[i]));
            }
            var testNames = Importer.importNames("../../../test-samples/simple-names.txt");
            Assert.Equal(testNames, people);
        }

        [Fact]
        public void emptyFileTest()
        {
            var testName = new List<Person> { };
            var people = Importer.importNames("../../../test-samples/blank.txt");
            Assert.Equal(testName, people);
        }

        [Fact]
        public void invalidNameTest()
        {
            Assert.Throws<ValidationOfFile>(() => Importer.importNames("../../../test-samples/no-first.txt"));
        }

        [Fact]
        public void noPermissionTest()
        {
            Assert.Throws<ValidationOfFile>(() => Importer.importNames("../../../test-samples/no-permission.txt"));
        }
    }
}
