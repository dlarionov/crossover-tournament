using System;

namespace Trial
{
    class Program
    {
        /*
         * Complete the function below.
         */
        static int[] balancedOrNot(string[] expressions, int[] maxReplacements)
        {
            int n = expressions.Length;
            int[] res = new int[n];

            for (int i = 0; i < n; i++)
            {
                res[i] = balancedOrNot(expressions[i], maxReplacements[i]);
            }

            return res;
        }

        static int balancedOrNot(string expression, int maxReplacements)
        {
            int cnt = 0;
            foreach (var i in expression.ToCharArray())
            {
                if (i == '<')
                {
                    cnt++;
                }
                else // if (i == '>')
                {
                    if (cnt > 0)
                    {
                        cnt--;
                    }
                    else
                    {
                        if (--maxReplacements < 0)
                        {
                            return 0;
                        };
                    }
                }
            }

            return cnt > 0 ? 0 : 1;
        }

        // DO NOT MODIFY CODE BELOW THIS LINE!
        static void Main(String[] args)
        {
            int[] res;

            int _expressions_size = 0;
            _expressions_size = Convert.ToInt32(Console.ReadLine());
            string[] _expressions = new string[_expressions_size];
            string _expressions_item;
            for (int _expressions_i = 0; _expressions_i < _expressions_size; _expressions_i++)
            {
                _expressions_item = Console.ReadLine();
                _expressions[_expressions_i] = _expressions_item;
            }

            int _maxReplacements_size = 0;
            _maxReplacements_size = Convert.ToInt32(Console.ReadLine());
            int[] _maxReplacements = new int[_maxReplacements_size];
            int _maxReplacements_item;
            for (int _maxReplacements_i = 0; _maxReplacements_i < _maxReplacements_size; _maxReplacements_i++)
            {
                _maxReplacements_item = Convert.ToInt32(Console.ReadLine());
                _maxReplacements[_maxReplacements_i] = _maxReplacements_item;
            }

            res = balancedOrNot(_expressions, _maxReplacements);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}