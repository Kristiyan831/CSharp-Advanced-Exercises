using System;
    
namespace BasicQueueOperation;

public class StartUp
{
    public static void Main() 
    {
        int[] stats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = stats[0];
        //number of elements to push into the stack
        int s = stats[1];
        // munber of elements to pop from the stack
        int x = stats[2];
        // element you should look for int stack
        int[] inputInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        List<int> enquedInts = new List<int>(n);

       Queue<int> queue = new Queue<int>(); 
        for (int i = 0; i < n; i++)
        {
            enquedInts.Add(inputInts[i]);
            queue.Enqueue(enquedInts[i]);
        }

        for (int j = 0; j < s; j++)
        {
            queue.Dequeue();
        }

        if (queue.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (queue.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            int min = enquedInts.AsQueryable().Min();
            Console.WriteLine(min);
        }



    }
}
