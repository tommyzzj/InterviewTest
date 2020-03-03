using System;
using System.Collections.Generic;

namespace ArgsProblem.Tests
{
    public class ValidateArguments
    {
        private readonly HashSet<string> _argument = new HashSet<string> { "--name", "--count", "--help" };

        public int Validate(string[] args)
        {
            if (args.Length == 0) return -1;

            var result = -1;
            var help = 0;

            for (var i = 0; i < args.Length; i++)
            {
                if (_argument.Contains(args[i].ToLower()))
                {
                    if (args[i].ToLower() == "--help")
                    {
                        help++;
                        continue;
                    }

                    try
                    {
                        if (Check(args[i], args[i + 1]))
                        {
                            return 0;
                        }
                        i++;
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        return -1;
                    }
                }
            }

            return help == 1 ? 1 : result;
        }

        private bool Check(string arg, string s)
        {
            if (string.IsNullOrWhiteSpace(s) || _argument.Contains(s)) return false;

            switch (arg)
            {
                case "--name":
                    return s.Length >= 3 && s.Length <= 10;
                case "--count" when int.TryParse(s, out var num):
                    return num >= 10 & num <= 100;
                default:
                    return false;
            }
        }
    }
}