using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork1
{
    public class Calculation
    {
        const int N = 100000;
        const int K = 20;

        public static void DoCalculations(double m, double a, double r0)
        {
            Generator gen = new Generator(a, m, r0);
            List<double> xList = new List<double>();

            foreach (double x in gen.GetNext().Take(N))
            {
                xList.Add(x);
            }

            double mX, dX, gammaX, indirectSignValue;
            int[] countInIntervals = new int[K];
            double xMin, xMax, yMax;
            int p, La;

            DoEstimationsCalculations(xList, out mX, out dX, out gammaX);
            DoDiagramCalculations(xList, countInIntervals, out xMin, out xMax, out yMax);

            CalculateIndirectSign(out indirectSignValue, xList);
            CalculatePeriodAndLa(xList, out p, out La);
        }

        private static void DoEstimationsCalculations(List<double> xList, out double Mx, out double Dx, out double GAMMAx)
        {
            double sum = 0, sumD = 0;

            foreach (double x in xList)
            {
                sum += x;
            }
            Mx = sum / N;
            foreach (double x in xList)
            {
                sumD += (x - Mx) * (x - Mx);
            }
            Dx = sumD / N;
            GAMMAx = Math.Sqrt(Dx);
        }

        private static void DoDiagramCalculations(List<double> xList, int[] countInIntervals, out double xMin, out double xMax, out double yMax)
        {
            int intervalNumber;

            FindXMaxMin(xList, out xMin, out xMax);

            if (xMax == xMin)
            {
                //countInIntervals[0] = N;
                yMax = 1;
                return;
            }

            foreach (double x in xList)
            {
                intervalNumber = (int)Math.Truncate((x - xMin - 0.000000001) / ((xMax - xMin) / K)); // (x - xMin - 0.000000001) because Ox starts with xMin
                countInIntervals[intervalNumber]++;
            }

            yMax = FindYMax(countInIntervals);
        }

        private static void FindXMaxMin(List<double> xList, out double xMin, out double xMax)
        {
            xMin = double.MaxValue;
            xMax = double.MinValue;

            foreach (double x in xList)
            {
                if (x < xMin)
                {
                    xMin = x;
                }

                if (x > xMax)
                {
                    xMax = x;
                }
            }
        }

        private static double FindYMax(int[] countInintervals)
        {
            int maxCount = int.MinValue;

            foreach (int count in countInintervals)
            {
                if (count > maxCount)
                {
                    maxCount = count;
                }
            }

            return Math.Round((double)maxCount / N, 2);
        }

        private static void CalculateIndirectSign(out double indirectSignValue, List<double> xList)
        {
            int k = 0;

            for (int i = 0; i < xList.Count; i += 2)
            {
                if (xList[i] * xList[i] + xList[i + 1] * xList[i + 1] < 1)
                {
                    k++;
                }
            }

            indirectSignValue = 2 * (double)k / N;
        }

        private static void CalculatePeriodAndLa(List<double> xList, out int p, out int La)
        {
            double checkingValue = xList[N - 1];
            int foundIndex = 0;

            for (int i = N - 2; i >= 0; i--)
            {
                if (xList[i] == checkingValue)
                {
                    foundIndex = i + 1;
                    break;
                }
            }

            p = N - foundIndex;
            La = p;

            if (p != N)
            {
                bool repeated = false;

                for (int i = 0; i < xList.Count; i++)
                {
                    for (int j = i + 1; j < xList.Count; j++)
                    {
                        if (xList[i] == xList[j])
                        {
                            repeated = true;
                            break;
                        }
                    }

                    if (repeated)
                    {
                        break;
                    }

                    La++;
                }
            }
        }
    }
}
