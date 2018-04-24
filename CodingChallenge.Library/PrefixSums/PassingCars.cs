using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.PrefixSums
{
    public class PassingCars
    {

        public int Solve(int[] A) {

            int previousEastTravelingCars = 0;
            int pairs = 0;

            for (int index = 0; index < A.Length; index++)
            {
                if (A[index] == 0)
                {
                    previousEastTravelingCars++;
                }
                else {
                    pairs += previousEastTravelingCars;
                }

                if (pairs > 1000000000) return -1;

            }

            return pairs;

        }

    }
}
