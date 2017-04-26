using System;

class Solution
{
    /*
     * Complete the function below.
     */
    static void superStack(string[] operations)
    {
        var stack = new Trial.SuperStack();
        foreach(var str in operations)
        {
            var arr = str.Split(' ');
            switch(arr[0])
            {
                case "push":
                    stack.Push(Convert.ToInt32(arr[1]));
                    break;
                case "pop":
                    stack.Pop();
                    break;
                case "inc":
                    stack.Inc(Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
                    break;
            }

            Console.WriteLine(stack.Count > 0 ? stack.Peek().ToString() : "EMPTY");
        }
    }

    // DO NOT MODIFY CODE BELOW THIS LINE!
    static void Main(String[] args)
    {
        int _operations_size = 0;
        _operations_size = Convert.ToInt32(Console.ReadLine());
        string[] _operations = new string[_operations_size];
        string _operations_item;

        for (int _operations_i = 0; _operations_i < _operations_size; _operations_i++)
        {
            _operations_item = Console.ReadLine();
            _operations[_operations_i] = _operations_item;
        }

        superStack(_operations);
    }
}