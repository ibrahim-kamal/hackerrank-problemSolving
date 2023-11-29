
//www.hackerrank.com/challenges/mini-max-sum/problem
namespace mini_max_sum;
class mini_max_sum
{
    public static void Main()
    {

        staircase(new List<int> { 5,5,5,5,5 });
    }


    public static void staircase(List<int> arr)
    {
        int max = arr.Max();
        int min = arr.Min();
        Int64 total = 0;
        int flag = 0;
        foreach (var item in arr)
        {
            if (item == max || item == min) {
                flag++;
            }
            if (!(item == max || item == min) || flag > 2) {
                total += item;
            }
        }



        Console.WriteLine($"{total + min} {total + max}");

    }
}