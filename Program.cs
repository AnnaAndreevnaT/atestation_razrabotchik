class Program
{
    private static string[] input = new string[] {"Moscow", "123", "abcd", "-1", "234", "Berlin"};

    public static void Main()
    {

        var output = new string[input.Length];
        int count = 0;

        for (var i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                output[i] = input[i];
                count = count + 1;
            }

        }

        var final = new string[count];
        var index = 0;

        foreach (var s in output)
        {
            if (s != null)
            {
                final[index] = s;
                index = index + 1;
            }
        }

        Console.WriteLine("Results: ");
        Console.WriteLine(string.Join(' ', final));
    }
}
