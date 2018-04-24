using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Sorting
{
    public class Triangle
    {

        public int Solve(int[] A)
        {
            Array.Sort(A);

            for (int index = 0; index < A.Length - 2; index++)
            {
                if (IsTriangular(A[index], A[index + 1], A[index + 2])) {
                    return 1;
                }
            }
            return 0;
        }

        public int SolveFirstSolution(int[] A) {

            int N = A.Length;

            for (int index = 0; index < N; index++)
            {
                int firstValue = A[index];
                for (int indexTwo = index + 1; indexTwo < N; indexTwo++)
                {
                    int secondValue = A[indexTwo];
                    for (int indexThree = indexTwo + 1; indexThree < N; indexThree++)
                    {
                        int thirdValue = A[indexThree];
                        if (IsTriangular(firstValue, secondValue, thirdValue)) {
                            return 1;
                        }
                    }

                }


            }
            return 0;
        }

        private bool IsTriangular(int firstValue, int secondValue, int thirdValue) {

            if (firstValue + secondValue <= thirdValue) return false;
            if (secondValue + thirdValue <= firstValue) return false;
            if (thirdValue + firstValue <= secondValue) return false;

            return true;

        }

    }
}
