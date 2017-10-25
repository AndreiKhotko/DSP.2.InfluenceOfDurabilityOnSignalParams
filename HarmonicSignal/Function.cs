using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HarmonicSignal
{
    /// <summary>
    /// Class that presents a function for harmonic signal x(n) = sin(2 * Pi * n / N + phase)
    /// </summary>
    public class Function
    {
        private int _k;
        private int _m;
        private int _n;

        /// <summary>
        /// A member representing a min value of M
        /// </summary>
        public int K
        {
            get { return _k; }
            set
            {
                if (value >= N)
                    throw new ArgumentException($"The value K = {value} is greater or equals N = {N}");

                _k = value;
            }
        }

        /// <summary>
        /// A Member representing a max value of parameter n
        /// </summary>
        public int M
        {
            get { return _m; }
            set
            {
                if (value < 0 || value > 5*N)
                    throw new ArgumentOutOfRangeException($"The value M = {value} is not between {K} and {2 * N}");

                _m = value;
            }
        }
        
        /// <summary>
        /// Here it is a period of a signal
        /// </summary>
        public int N
        {
            get { return _n; }
            set
            {
                if (value < 64)
                    throw new ArgumentException($"The value {value} is less than 64");
                if (!IsPowerOfTwo(value))
                    throw new ArgumentException($"The value {value} is not a power of two");

                _n = value;
            }
        }

        /// <summary>
        /// Representing a phase of a signal
        /// </summary>
        public double Phase { get; set; }

        public double RootMeanSquareValueA
        {
            get
            {
                double sum = 0;
                for (int n = 0; n < M; n++)
                {
                    var x = GetValue(n);
                    sum += x * x;
                }

                var underRootExpression = sum * 1 / (M + 1);

                return Math.Sqrt(underRootExpression);
            }
        }

        public double RootMeanSquareValueB
        {
            get
            {
                double sum = 0;
                for (int n = 0; n < M; n++)
                {
                    var x = GetValue(n);
                    sum += x * x;
                }

                var leftUnderRootExpr = sum * 1 / (M + 1);

                sum = 0;
                for (int n = 0; n < M; n++)
                {
                    var x = GetValue(n);
                    sum += x;
                }

                var rightUnderRootExpr = (sum * 1 / (M + 1));
                rightUnderRootExpr *= rightUnderRootExpr; // Sqr(rightUnderRootExpr)

                var underRootExpression = leftUnderRootExpr - rightUnderRootExpr;

                return Math.Sqrt(underRootExpression);
            }
        }

        public double Amplitude
        {
            get
            {
                double As = 0;
                double Ac = 0;

                for (int n = 0; n < M; n++)
                {
                    As += GetValue(n) * Math.Sin(2 * Math.PI * n / M);
                    Ac += GetValue(n) * Math.Cos(2 * Math.PI * n / M);
                }

                Ac *= 2.0 / M;
                As *= 2.0 / M;

                return Math.Sqrt(Ac * Ac + As * As);
            }
        }

        public Function(int n, int k, int m, double phase = 0)
        {
            N = n;
            K = k;
            M = m;
            Phase = phase;
        }

        public double GetValue(int n) => Math.Sin(2 * Math.PI * n / N + Phase);

        private static bool IsPowerOfTwo(int number) => (Math.Abs(Math.Log(number, 2) % 1) <= double.Epsilon * 100);
    }
}
