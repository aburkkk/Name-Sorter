using Xunit;
using NameSorter;

namespace NameSorterTest
{
    public class PersonTester
    {
        /*
         * Check that the Person class's ToString method works correctly
         */
        [Fact]
        public void stringTest()
        {
            var a = new Person("Hunter Uriah Mathew", "Clarke");
            Assert.Equal(a.ToString(), "Hunter Uriah Mathew Clarke");
        }

        /*
         * Check that equality works for the Person class
         */
        [Fact]
        public void equalsTest()
        {
            var a = new Person("Hunter Uriah Mathew", "Clarke");
            var b = new Person("Hunter Uriah Mathew", "Clarke");
            var c = new Person("Janet", "Parsons");
            Assert.Equal(a, b);
            Assert.NotEqual(a, c);
        }
    }
}
