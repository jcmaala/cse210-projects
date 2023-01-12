using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> num_list = new List<float>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("Enter number: ");
        string numbers = Console.ReadLine();
        float num_fin = float.Parse(numbers);
        num_list.Add(num_fin);
        int sum = 0;
        float item_counter = 0;
        float ave = 0;
        
        while (num_fin != 0)
        {
            Console.Write("Enter number: ");
            numbers = Console.ReadLine();
            num_fin = int.Parse(numbers);
            num_list.Add(num_fin);
        }

        foreach (int num in num_list)
        {
            sum+= num;
            item_counter ++;
        }
        float total_counter = item_counter - 1;
        ave = sum / total_counter;
        float max_num = num_list.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {max_num}");
        
    }
}