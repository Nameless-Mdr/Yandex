namespace Lesson.Two.LargestProductOfTwoNumbers;

public static class Solution2G
{
    public static (long, long) GetMaxProductOfTwoNumbers(long[] numbers)
    {
        var firstMax = numbers[0];
        var secondMax = numbers[1];
        
        var firstMin = numbers[0];
        var secondMin = numbers[1];

        for (var i = 2; i < numbers.Length; i++)
        {
            var num = numbers[i];
            
            if (num > firstMax)
            {
                secondMax = firstMax;
                firstMax = num;
            }
            else if(num > secondMax)
            {
                secondMax = num;
            }

            if (num < firstMin)
            {
                secondMin = firstMin;
                firstMin = num;
            }
            else if(num < secondMin)
            {
                secondMin = num;
            }
        }

        if (firstMax * secondMax > firstMin * secondMin)
        {
            return firstMax > secondMax ? (secondMax, firstMax) : (firstMax, secondMax);
        }

        return firstMin > secondMin ? (secondMin, firstMin) : (firstMin, secondMin);
    }
}