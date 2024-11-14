namespace Lesson.Two.LargestProductOfThreeNumbers;

public static class Solution2H
{
    public static (long Num1, long Num2, long Num3) Run(long[] numbers)
    {
        var sort = new long[] { numbers[0], numbers[1], numbers[2] }
            .OrderByDescending(x => x)
            .ToArray();
        
        var firstMax = sort[0];
        var secondMax = sort[1];
        var thirdMax = sort[2];

        var firstMin = thirdMax;
        var secondMin = secondMax;
        var thirdMin = firstMax;

        for (int i = 3; i < numbers.Length; i++)
        {
            var num = numbers[i];

            if (num > firstMax)
            {
                thirdMax = secondMax;
                secondMax = firstMax;
                firstMax = num;
            }
            else if (num > secondMax)
            {
                thirdMax = secondMax;
                secondMax = num;
            }
            else if (num > thirdMax)
            {
                thirdMax = num;
            }

            if (num < firstMin)
            {
                thirdMin = secondMin;
                secondMin = firstMin;
                firstMin = num;
            }
            else if (num < secondMin)
            {
                thirdMin = secondMin;
                secondMin = num;
            }
            else if (num < thirdMin)
            {
                thirdMin = num;
            }
        }

        return firstMax * secondMax * thirdMax > firstMin * secondMin * firstMax
            ? (firstMax, secondMax, thirdMax)
            : (firstMax, secondMin, firstMin);
    }
}