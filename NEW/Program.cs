using System;
    
namespace BasicQueueOperation;

public class StartUp
{
    public static void Main() 
    {
        int queries = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < queries; i++)
        {
            int[] querie = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (querie[0] == 1)
            {
                stack.Push(querie[1]);
            }
            else if (querie[0] == 2)
            {
                stack.Pop();
            }
            else if (querie[0] == 3)
            {
                Console.WriteLine(stack.AsQueryable().Max());
            }
            else if (querie[0] == 4)
            {
                Console.WriteLine(stack.AsQueryable().Min());
            }
        }
        Console.WriteLine(string.Join(", ",stack));


    }
}
