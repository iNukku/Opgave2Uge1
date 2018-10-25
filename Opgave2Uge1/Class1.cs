using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave2Uge1
{
    class Comparisson
    {
        private bool isAcronym = false;
        char[] firstarray;
        char[] secondarray;

        public Comparisson(string a, string b)
        {
            firstarray = a.ToCharArray();
            secondarray = b.ToCharArray();

            Array.Sort(firstarray);
            Array.Sort(secondarray);
        }

        public bool compair() { 
            for (int i = 0; i < firstarray.Length; i++)
            {
                if (firstarray[i] == secondarray[i])
                {
                    isAcronym = true;
                }
                else
                {
                    isAcronym = false;
                    break;
                }
            }

            return isAcronym;
            
        }


    }
}
