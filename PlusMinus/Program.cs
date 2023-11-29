
//www.hackerrank.com/challenges/diagonal-difference/problem
namespace PlusMinus;
class PlusMinus
{
    public static void Main()
    {

        Plus_Minus(new List<int> { -4, 3, -9, 0, 4, 1 });
    }


    public static void Plus_Minus(List<int> arr)
    {

        int length = arr.Count();
        int count_postive = 0;
        int count_negative = 0;
        int count_zero = 0;
        for (int i = 0; i < length; i++)
        {
            if (arr[i] == 0)
            {
                count_zero++;
            }
            else if (arr[i] > 0)
            {
                count_postive++;
            }
            else { 
                count_negative++;
            }

        }

        decimal postive = ((decimal)count_postive / length) ;
        decimal negative =((decimal) count_negative / length);
        decimal zero =((decimal) count_zero / length);
            

        Console.WriteLine(Math.Round(postive, 6));
        Console.WriteLine(Math.Round(negative, 6));
        Console.WriteLine(Math.Round(zero, 6));




    }
}