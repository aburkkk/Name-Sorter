using System;
namespace NameSorter
{
    public class Person
    {
        public string firstNames { get; }
        public string lastName { get; }
        public Person(string firstNames, string lastName)
        {
            this.firstNames = firstNames;
            this.lastName = lastName;
        }

        public override string ToString() => $"{firstNames} {lastName}";

        public override bool Equals(Object obj)
        {
            // If both objects are not of type Person, return false
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Person p = (Person)obj;

            return firstNames == p.firstNames && lastName == p.lastName;
        }

        public override int GetHashCode() => firstNames.GetHashCode() * 97 + lastName.GetHashCode();
    }
}
