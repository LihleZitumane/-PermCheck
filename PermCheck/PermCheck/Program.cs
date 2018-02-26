using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermCheck
{
    class Program
    {

        static int solution(int[] A)
        {
            List<int> x = new List<int>();

            if (A.Length != 0) { 
                x = A.ToList<int>();

                if (!A.Contains(1))
                    return 0;
                var query = x.GroupBy(y => y).Where(i => i.Count() > 1).Select(p => p);
                var duplicates = query.ToArray();
                if (duplicates.Length > 0)
                    return 0;

                Array.Sort(A);
                for (int i=1; i < A.Length; i++)
                {
                    if (A[i] != A[i - 1] + 1)
                        return 0;
                }
                return 1;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            Console.Write(solution(new int[] {1}));
            Console.ReadKey();
        }
    }
}
