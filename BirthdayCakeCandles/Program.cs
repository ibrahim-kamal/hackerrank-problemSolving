
//www.hackerrank.com/challenges/mini-max-sum/problem
namespace BirthdayCakeCandles;
class BirthdayCakeCandles
{
    public static void Main()
    {

        birthdayCakeCandles(new List<int> { 3,2,1,3 });
    }


    public static int birthdayCakeCandles(List<int> candles)
    {
        int max = candles.Max();
        int count = 0;
        foreach (var i in candles)
        {
            if (i == max) { 
                count++;
            }
        }
        return count;

    }
}