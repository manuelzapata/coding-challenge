using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.PrefixSums
{
    public class CountDiv
    {

        public int Solve(int A, int B, int K) {

            if (K > B) return 0;

            int closestDivider = 0;
            if (K <= A) {
                closestDivider = (A / K) * K;
            } else {
                closestDivider = K;
            }

            int result = (B - closestDivider) / K;

            if (closestDivider >= A) result++;

            if (A == 0) result++;

            return result;

        }

        public int SolveFirstSolution(int A, int B, int K)
        {

            if (K > B) return 0;

            int closestDivider = 0;
            if (K <= A)
            {
                closestDivider = (A / K) * K;
            }
            else
            {
                closestDivider = K;
            }

            int result = (B - closestDivider) / K;

            if (closestDivider >= A) result++;

            return result;

        }

    }
}
