using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    struct Line_yrav
    {
        double k;
        double b;

        public Line_yrav (double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            double X = b / k;
            if (k == 0)
              return "Нет решений";
            return $"Ответ: х = {X}";
        }
    }
}
