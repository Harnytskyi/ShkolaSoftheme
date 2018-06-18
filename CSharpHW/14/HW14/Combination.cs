using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14
{
    public class Combination
    {
        public Number[] Numbers;
        int position = 0;

        public Combination()
        {
           Numbers = new Number[6];
        }

        public void AddNumber(int num)
        {
            var number = new Number(num);
            Numbers[position] = number;
            position++;
        }
        public void Generate()
        {
            var random = new Random();
            while (position < Numbers.Length)
            {
                AddNumber(random.Next(1, 10));
            }
        }

        public Number this[int index]
        {
            get
            {
                return Numbers[index];
            }
            set
            {
                Numbers[index] = value;
            }
        }
        public string PrintNumbers()
        {
            string print = string.Empty;
            foreach (Number num in Numbers)
            {
                if (num != null)
                {
                    print += num.Num + " ";
                }
            }
            return print;
        }
    }
}
