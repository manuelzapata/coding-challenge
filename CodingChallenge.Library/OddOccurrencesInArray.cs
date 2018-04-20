using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library
{
    public class OddOccurrencesInArray
    {

        public int Solve(int[] A)
        {
            Dictionary<int, int> reviewedNumbers = new Dictionary<int, int>();
            for (int index = 0; index < A.Length; index++)
            {
                int currentNumber = A[index];
                if (reviewedNumbers.ContainsKey(currentNumber))
                {
                    reviewedNumbers[currentNumber] = reviewedNumbers[currentNumber] + 1;
                }
                else {
                    reviewedNumbers[currentNumber] = 1;
                }
            }

            foreach (KeyValuePair<int, int> pair in reviewedNumbers) {
                if (pair.Value % 2 != 0) return pair.Key;
            }

            return 0;
        }

        /**
         * This solution works but the performance is not good enough.
         * With a number of items > 100000, performance degrades significantly.
         */
        public int SolveFirstSolution(int[] A) {

            int result = -1;
            List<int> reviewedNumbers = new List<int>();

            for (int index = 0; index < A.Length && result == -1; index++)
            {
                if (!reviewedNumbers.Contains(A[index])) {

                    int count = 1;
                    for (int index2 = index + 1; index2 < A.Length; index2++)
                    {
                        if (A[index2] == A[index]) count++;
                    }

                    if (count % 2 != 0) result = A[index];
                    reviewedNumbers.Add(A[index]);

                }
            }

            return result;
        }

    }
}
