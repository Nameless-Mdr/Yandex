namespace Lesson.Two.Sapper;

public static class Solution2I
{
    public static void Run()
    {
        var input = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var n = input[0];
        var m = input[1];
        var k = input[2];

        var minefield = new int[n, m];

        for (var i = 0; i < k; i++)
        {
            var coordinates = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Select(x => x - 1).ToArray();
            
            var row = coordinates[0];
            var col = coordinates[1];
            
            minefield[row, col] = 9;

            if (row - 1 >= 0)
            {
                if(col - 1 >= 0)
                    minefield[row -1, col - 1]++;
                
                minefield[row - 1, col]++;
                
                if(col + 1 < m)
                    minefield[row - 1, col + 1]++;
            }
            
            if(col - 1 >= 0)
            {
                minefield[row, col - 1]++;
            }
            if(col + 1 < m)
            {
                minefield[row, col + 1]++;
            }

            if (row + 1 < n)
            {
                if(col - 1 >= 0)
                    minefield[row + 1, col - 1]++;
                
                minefield[row + 1, col]++;
                
                if(col + 1 < m)
                    minefield[row + 1, col + 1]++;
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                Console.Write(minefield[i, j] >= 9 ? "* " : $"{minefield[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}