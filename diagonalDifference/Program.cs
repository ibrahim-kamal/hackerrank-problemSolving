
//www.hackerrank.com/challenges/diagonal-difference/problem
namespace diagonalDifference;
class diagonalDifference {
    public static void Main() {


    }


    public static int DiagonalDifference(List<List<int>> arr)
    {
        int right = 0;
        int left = 0;
        int length = arr.Count();
        for (int i = 0; i < length; i++)
        {
            right += arr[i][i];
            left  += arr[length - 1 -i][i];
        }

        return Math.Abs(right - left);

    }
}