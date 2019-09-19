using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork1
{
    public static class ValueChecking
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
