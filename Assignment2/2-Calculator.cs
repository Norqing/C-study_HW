using System;

namespace Assignment2
{
    class Calculator
    {
        public static void Calculate(double[] nums, out double max,
           out double min, out double average, out double sum)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("数组错误！");
            }
            max = nums[0];
            min = nums[0];
            sum = 0;
            foreach (double n in nums)
            {
                if (n < min) min = n;
                if (n > max) max = n;
                sum += n;
            }
            average = sum / nums.Length;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("请输入你所想计算的整数数组的元素个数：");
            int n = int.Parse(Console.ReadLine());
            double[] nums = new double[n];
            Console.WriteLine("请依次输入你所想计算的整数数组的元素：");
            for (int i = 0; i < n; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }
            double max, min, average, sum;
            Calculate(nums, out max, out min, out average, out sum);
            try
            {
                Console.WriteLine(
                    $"该数组的最大值为{max},最小值为{min},平均值为{average},所有数组元素和为{sum}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
