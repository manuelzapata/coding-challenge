using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library
{
    public class FrogJump
    {

        public int Solve(int X, int Y, int D) {
            int distance = Y - X;
            int jumpCount = distance / D;
            if (distance % D > 0) {
                jumpCount++;
            }
            return jumpCount;
        }

    }
}
