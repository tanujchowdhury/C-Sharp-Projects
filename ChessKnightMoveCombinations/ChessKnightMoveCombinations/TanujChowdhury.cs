using System;

namespace TanujChowdhury
{
    class TanujChowdhury
    {
        static void Main()
        {
            Console.WriteLine(SolveMatrix());
        }
                
        public static long SolveMatrix()
        {
            int n = 8; // Length of the combination = 8
            int v = 2; // Vowel limit = 2
            // Store the possible solutions in a 3D array
            int[,,] moves = new int[n + 1, 5, 5];
            long ans = 0;
            // Do n moves from every i, j index
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ans = (ans + Paths(moves, i, j, n, v));
                }
            }
            return ans;
        }

        private static int Paths(int[,,] moves, int i, int j, int n, int v)
        {
            // If the knight jumps outside the matrix or into an empty square, return 0 because there are no paths from there
            if (i < 0 || j < 0 || i >= 5 || j >= 5 || (i == 0 && j == 3) || (i == 1 && j == 0) || (i == 4 && j == 2) || (i == 4 && j == 3)) return 0;
            // If the knight jumps on a vowel decrement v and check if vowel limit is reached
            if ((i == 0 && j == 0) || (i == 0 && j == 4) || (i == 1 && j == 3) || (i == 2 && j == 4) || (i == 4 && j == 0) || (i == 4 && j == 4))
            {
                v -= 1;
                // If v goes below 0 the vowel limit is reached. Return 0 because there are no paths from there
                if (v < 0) return 0;
            }
            // Trivial solution
            if (n == 1) return 1;
            // If the solution is already stored then return it
            if (moves[n, i, j] > 0) return moves[n, i, j];
            // Otherwise compute and store the solution
            moves[n, i, j] = Paths(moves, i - 1, j - 2, n - 1, v) + 
                             Paths(moves, i - 2, j - 1, n - 1, v) + 
                             Paths(moves, i - 2, j + 1, n - 1, v) + 
                             Paths(moves, i - 1, j + 2, n - 1, v) + 
                             Paths(moves, i + 1, j + 2, n - 1, v) + 
                             Paths(moves, i + 2, j + 1, n - 1, v) + 
                             Paths(moves, i + 2, j - 1, n - 1, v) + 
                             Paths(moves, i + 1, j - 2, n - 1, v);
            return moves[n, i, j];
        }
    }
}
