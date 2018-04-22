using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Counting
{
    public class MaxCounters
    {

        public int[] Solve(int N, int[] A) {

            int[] counters = new int[N];
            int maxCounter = 0;
            int pendingMaxCounter = -1;

            for (int index = 0; index < A.Length; index++)
            {

                if (A[index] == N + 1)
                {
                    pendingMaxCounter = maxCounter;
                }
                else {

                    int counter = A[index] - 1;

                    //There is a pending counter value to assign, so let's do it now.
                    if (counters[counter] < pendingMaxCounter) {
                        counters[counter] = pendingMaxCounter;
                    }

                    counters[counter] += 1;
                    if (counters[counter] > maxCounter) {
                        maxCounter = counters[counter];
                    }
                }
            }

            //There could be counters that never got the pending counter value assign.
            for (int index = 0; index < counters.Length; index++)
            {
                if (counters[index] < pendingMaxCounter) {
                    counters[index] = pendingMaxCounter;
                }
            }

            return counters;
        }

        public int[] SolveFirstSolution(int N, int[] A)
        {

            int[] counters = new int[N];
            int maxCounter = 0;

            for (int index = 0; index < A.Length; index++)
            {

                if (A[index] == N + 1)
                {
                    //operation is max counter
                    for (int counterIndex = 0; counterIndex < counters.Length; counterIndex++)
                    {
                        counters[counterIndex] = maxCounter;
                    }
                }
                else
                {

                    int counter = A[index] - 1;
                    counters[counter] += 1;
                    if (counters[counter] > maxCounter)
                    {
                        maxCounter = counters[counter];
                    }
                }

            }

            return counters;
        }

    }
}
