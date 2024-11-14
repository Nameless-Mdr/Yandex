namespace Lesson.Two.SymmetricSequence;

public static class Solution2F
{
    public static void Run()
    {
        var n = int.Parse(Console.ReadLine()!);
        var array = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var left = 0;
        var rigth = n - 1;
        var move = 1;
        var result = new List<int>();

        while (left < rigth)
        {
            if (array[left] != array[rigth])
            {
                result.Insert(0, array[left - move + 1]);
                left = left - move + 2;
                rigth = rigth + move - 1;

                move = 1;
            }
            else
            {
                left++;
                rigth--;
                move++;
            }
        }

        Console.WriteLine(result.Count);
        Console.WriteLine(string.Join(" ", result));
    }
}