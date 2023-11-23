using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing___Swapping_Values_Example
{
   public class Swapping
    {
       public void swapTwoValues(ref int val1, ref int val2)
       {
           int temp = val1;
           val1 = val2;
           val2 = temp;
       }

    }
}
