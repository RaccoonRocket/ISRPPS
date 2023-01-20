using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isrpps_2
{
    public class Controller
    {
        int start = 0;
        int end = 5;
        int[,] graph = new int[,] {
            { 0, 16, 13, 0, 0, 0 }, { 0, 0, 10, 12, 0, 0 },
            { 0, 4, 0, 0, 14, 0 },  { 0, 0, 9, 0, 0, 20 },
            { 0, 0, 0, 7, 0, 4 },   { 0, 0, 0, 0, 0, 0 }
        };

        public int maxFlow()
        {
            Delegator d = new Delegator();
            return d.MaxFlow(start, end, graph);
        }
    }
}
