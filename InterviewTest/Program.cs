using System;
using ArgsProblem.Tests;

namespace InterviewTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var validator = new ValidateArguments();

            var testString1 = new [] { "--name" };
            var testString2 = new [] { "--name", "test" };
            var testString3 = new [] { "--name", "--count" };
            var testString4 = new [] { "anme", "test" };

            Console.WriteLine(validator.Validate(testString4));
        }
    }
}
