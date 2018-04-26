using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.Library.StacksQueues
{
    public class Nesting
    {
        public const char ClosingParenthesis = ')';

        public int Solve(string S) {

            int N = S.Length;
            if (N == 0) return 1;

            int openParenCount = 0;

            for (int index = 0; index < N; index++)
            {
                int currentCharacter = S[index];
                if (currentCharacter == ClosingParenthesis)
                {

                    if (openParenCount > 0)
                    {
                        openParenCount--;
                    }
                    else
                    {
                        //There are more closing parens that opening parens.
                        return 0;
                    }

                }
                else {
                    openParenCount++;
                }
            }

            int result = 1;
            if (openParenCount > 0) result = 0;
            return result;

        }

    }
}
