namespace ConsoleApps
{
    using System;
    using System.Collections.Generic;
    public class Kata
    {
        public static bool Narcissistic(int value)
        {
            int initValue = value;
            int newValue = default;
            List<int> nums = new List<int>();

            while (value >= 10)
            {
                nums.Add(value%10);
                value /= 10;
            }
            if (value < 10)
            {
                nums.Add(value);
            }
            foreach(int num in nums)
            {
                newValue += (int)Math.Pow(num, nums.Count);
                
            }
           
            return initValue == newValue;
        }
    }

    //[TestFixture]
    //public class Sample_Test
    //{
    //    private static IEnumerable<TestCaseData> testCases
    //    {
    //        get
    //        {
    //            yield return new TestCaseData(1)
    //                            .Returns(true)
    //                            .SetDescription("1 is narcissitic");
    //            yield return new TestCaseData(371)
    //                            .Returns(true)
    //                            .SetDescription("371 is narcissitic");
    //
    //        }
    //    }
    //
    //    [Test, TestCaseSource("testCases")]
    //    public bool Test(int n) => Kata.Narcissistic(n);
    //}
}
