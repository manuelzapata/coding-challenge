using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.Counting
{
    public class FrogRiverOne
    {

        public int Solve(int X, int[] A) {

            int[] path = new int[X];
            int filledPositions = 0;

            for (int index = 0; index < A.Length; index++)
            {
                int leafPosition = A[index] - 1;
                if (path[leafPosition] == 0) {
                    path[leafPosition] = 1;
                    filledPositions++;
                }

                if (filledPositions == X) return index;
            }

            return -1;
        }

    }
}
