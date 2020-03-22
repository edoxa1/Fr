using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fr
{
    class Calculate
    {
        public int num1 = 0;
        public int num2 = 0;

        public void Show()
        {
            Console.WriteLine($"Number1 = {num1}; Number2 = {num2}");
        }
        public void ChangeNum(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void SumOfNums()
        {
            Console.WriteLine($"Sum: {num1+num2}");
        }
        public void MaxNum()
        {
            if(num1 > num2)
            {
                Console.WriteLine($"Max number: {num1}");
            }
            else if(num2 > num1)
            {
                Console.WriteLine($"Max number: {num2}");
            }
            else
            {
                Console.WriteLine($"Numbers are equal");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calc.ChangeNum(5, 14);
            calc.Show();
            calc.SumOfNums();
            calc.MaxNum();
            calc.Show();
            Console.ReadKey();
        }
    }
}
