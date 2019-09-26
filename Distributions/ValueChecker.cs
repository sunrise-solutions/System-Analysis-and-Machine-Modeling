using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributions
{
    public static class ValueChecker
    {
        public static bool IsValid(string text)
        {
            int number;

            if (int.TryParse(text, out number))
            {
                if (number <= 0)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
