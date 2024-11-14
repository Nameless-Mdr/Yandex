namespace Lesson.Three.Solution3A;

public static class Solution3A
{
    public static void Run()
    {
        var numbers = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var hashSet = new HashSet<int>(numbers);

        foreach (var number in numbers)
        {
            hashSet.Add(number);
        }
        
        Console.WriteLine(hashSet.Count);
    }
}