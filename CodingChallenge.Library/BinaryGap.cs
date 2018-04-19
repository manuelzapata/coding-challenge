using System;

namespace CodingChallenge.Library
{
    public class BinaryGap
    {

        public int Solve(int N) {
            string binaryNumber = Convert.ToString(N, 2);
            int longestGap = 0;
            int currentGap = 0;

            for (int index = 0; index < binaryNumber.Length; index++)
            {
                if (binaryNumber[index] == '1')
                {
                    if (currentGap > longestGap)
                    {
                        longestGap = currentGap;
                    }
                    currentGap = 0;
                }
                else if (binaryNumber[index] == '0')
                {
                    currentGap++;
                }
            }

            return longestGap;
        }

    }
}
