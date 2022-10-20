using System;
    namespace NEW;
public class BasicStackOperations
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
        List<int> pushedInts = new List<int>(n);
        
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < n; i++)
        {
            pushedInts.Add(inputInts[i]);
            stack.Push(pushedInts[i]);
        }

        for (int j = 0; j < s; j++)
        {
            stack.Pop();
        }

        if (stack.Contains(x))
        {
            Console.WriteLine("true");
        }
        else if (stack.Count==0)
        {
            Console.WriteLine("0");
        }
        else
        {
               int min=  pushedInts.AsQueryable().Min();
            Console.WriteLine(min);
        }
       
    

               


    }
}
