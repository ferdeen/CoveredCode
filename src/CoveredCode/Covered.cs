using System;

namespace CoveredCode
{
    public class Covered
    {
        public int SquareRoot(int squared)
        {
            if (squared < 0)
                throw new NotImplementedException("no complex root");
            
            var root = Math.Sqrt(squared);
            if (Math.Abs(root % 1) <= (double.Epsilon * 100))
                return (int)root;

            else
                throw new NotImplementedException("no integer root");
            
        }
    }
}
