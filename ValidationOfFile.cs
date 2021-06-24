using System;
namespace NameSorter
{
    public class ValidationOfFile : System.Exception
    {
        public ValidationOfFile() : base() { }
        public ValidationOfFile(string message) : base(message) { }
        public ValidationOfFile(string message, System.Exception inner) : base(message, inner) { }
    }
}
