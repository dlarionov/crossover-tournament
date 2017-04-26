using System;

namespace Trial
{
    class Program
    {
        /*
         * Complete the function below.
         */
        static int[] jobOffers(int[] scores, int[] lowerLimits, int[] upperLimits)
        {
            if (upperLimits.Length != lowerLimits.Length)
                throw new ArgumentOutOfRangeException();

            int n = scores.Length;
            int q = lowerLimits.Length;

            int[] reversed = new int[n];

            Array.Sort(scores);
            Array.Copy(scores, reversed, n);
            Array.Reverse(reversed);

            int[] res = new int[q];

            for (int i = 0; i < q; i++)
            {
                int left = binarySearch(scores, (m) => scores[m] < lowerLimits[i]);
                int right = binarySearch(scores, (m) => reversed[m] > upperLimits[i]);

                if (left >= 0 && right >= 0)
                    res[i] = n - right - left;
                else if (left >= 0)
                    res[i] = n - left;
                else if (right >= 0)
                    res[i] = n - right;
                else
                    res[i] = 0;
            }

            return res;
        }

        /// <summary>
        /// Find the index of the first element from which the predicate is true
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        static int binarySearch(int[] arr, Predicate<int> predicate)
        {
            // l is the left index of the array minus one
            // r is the right index of the array plus one
            // we never call arr[-1] or arr[n], so there is nothing wrong
            int l = -1;
            int r = arr.Length;
            while ((r - l) > 1)
            {
                int m = l + ((r - l) / 2);
                if (predicate(m))
                {
                    l = m;
                }
                else
                {
                    r = m;
                }
            }

            return r < arr.Length ? r : -1;
        }

        //static void Main(String[] args)
        //{
        //    jobOffers(new[] { 1, 3, 5, 6, 8 }, new[] { 2 }, new[] { 6 });
        //    jobOffers(new[] { 4, 8, 7 }, new[] { 2, 4 }, new[] { 8, 4 });
        //}

        // DO NOT MODIFY CODE BELOW THIS LINE!
        static void Main(String[] args)
        {
            int[] res;

            int _scores_size = 0;
            _scores_size = Convert.ToInt32(Console.ReadLine());
            int[] _scores = new int[_scores_size];
            int _scores_item;
            for (int _scores_i = 0; _scores_i < _scores_size; _scores_i++)
            {
                _scores_item = Convert.ToInt32(Console.ReadLine());
                _scores[_scores_i] = _scores_item;
            }


            int _lowerLimits_size = 0;
            _lowerLimits_size = Convert.ToInt32(Console.ReadLine());
            int[] _lowerLimits = new int[_lowerLimits_size];
            int _lowerLimits_item;
            for (int _lowerLimits_i = 0; _lowerLimits_i < _lowerLimits_size; _lowerLimits_i++)
            {
                _lowerLimits_item = Convert.ToInt32(Console.ReadLine());
                _lowerLimits[_lowerLimits_i] = _lowerLimits_item;
            }


            int _upperLimits_size = 0;
            _upperLimits_size = Convert.ToInt32(Console.ReadLine());
            int[] _upperLimits = new int[_upperLimits_size];
            int _upperLimits_item;
            for (int _upperLimits_i = 0; _upperLimits_i < _upperLimits_size; _upperLimits_i++)
            {
                _upperLimits_item = Convert.ToInt32(Console.ReadLine());
                _upperLimits[_upperLimits_i] = _upperLimits_item;
            }

            res = jobOffers(_scores, _lowerLimits, _upperLimits);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}