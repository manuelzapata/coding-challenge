using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.PrefixSums
{
    public class GenomicRangeQuery
    {

        public int[] Solve(string S, int[] P, int[] Q) {

            Dictionary<char, int> nucleotideMap = new Dictionary<char, int> {
                { 'A', 0 },
                { 'C', 1 },
                { 'G', 2 },
                { 'T', 3 }
            };

            int N = S.Length;
            int[,] prefixSums = new int[N + 1, 4];
            int[] result = new int[P.Length];

            //Sum previous values
            for (int index = 0; index < N; index++)
            {
                int nucleotide = nucleotideMap[S[index]];
                prefixSums[index + 1, 0] = prefixSums[index, 0];
                prefixSums[index + 1, 1] = prefixSums[index, 1];
                prefixSums[index + 1, 2] = prefixSums[index, 2];
                prefixSums[index + 1, 3] = prefixSums[index, 3];

                prefixSums[index + 1, nucleotide] += 1;
            }

            for (int index = 0; index < P.Length; index++)
            {
                int startIndex = P[index] + 1;
                int endIndex = Q[index] + 1;

                int countA = prefixSums[endIndex, 0] - prefixSums[startIndex, 0] + (S[startIndex - 1] == 'A' ? 1: 0);
                int countC = prefixSums[endIndex, 1] - prefixSums[startIndex, 1] + (S[startIndex - 1] == 'C' ? 1 : 0);
                int countG = prefixSums[endIndex, 2] - prefixSums[startIndex, 2] + (S[startIndex - 1] == 'G' ? 1 : 0);
                int countT = prefixSums[endIndex, 3] - prefixSums[startIndex, 3] + (S[startIndex - 1] == 'T' ? 1 : 0);

                if (countA > 0)
                {
                    result[index] = 1;
                }
                else if (countC > 0)
                {
                    result[index] = 2;
                }
                else if (countG > 0)
                {
                    result[index] = 3;
                }
                else if (countT > 0) {
                    result[index] = 4;
                }

            }


            return result;
        }

    }
}
