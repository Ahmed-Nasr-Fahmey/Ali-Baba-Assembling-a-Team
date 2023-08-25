using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem
{
    public static class AliBabaAssembleTeam
    {
        #region YOUR CODE IS HERE
        static public long AssembleTeam(int N, short[] array)
        {
            long MinSequenceCost = long.MaxValue; //Max value = 9223372036854775807   so, ..1) initialize MinSequenceCost to the maximum possible value(Max of Long data type)
            long SumArray = 0;                     //2)  initialize SumArray to 0      

            if (N <= 0 || array == null || array.Length != N) //3) test the general and possible tests that make code not valid  
            {
                return 0;

            }

            foreach (long EleMeNt in array)            // 0, 5, -3, 4, -3, -6, -1, 9, -16, 30
            {
                SumArray += EleMeNt;                   //4) add the current element to SumArray       

                if (SumArray < MinSequenceCost)        // current 0  5  0 -3  1  0  -3 -9 -10  -1 -17  13  0   
                {
                    MinSequenceCost = SumArray;       //5) update MinSequenceCost to the minimum of currentSum and SumArray    // min sum 0 -3  -3  -9 -10 -1 -17 
                }

                if (SumArray > 0)                    //6) reset SumArray to 0 if it becomes positive   
                {
                    SumArray = 0;
                }
            }

            return MinSequenceCost; // 7)finally ..return the MinSequenceCost subarray sum

            // return MinSequenceCost == long.MaxValue ? 0 : MinSequenceCost;
        }


        #endregion
    }
}
