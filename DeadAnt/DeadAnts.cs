using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeadAnts
{
    class DeadAnts
    {
        public static int deadAntCount(String ants)
        {
            int IsNotAnt = 0;
            if (ants == null)
            {
                return IsNotAnt;
            }
            string ReplaceAntToSpace = ants.Replace("ant", "");
            IsNotAnt = "ant".Select(x => ReplaceAntToSpace.Count(c => c == x)).Max();
            return IsNotAnt;
        }
    }
}
