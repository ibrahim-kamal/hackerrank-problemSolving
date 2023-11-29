
//www.hackerrank.com/challenges/staircase/problem
namespace Staircase;
class Staircase
{
    public static void Main()
    {

        staircase(4);
    }


    public static void staircase(int i )
    {
        for (int repeat = 0 ; repeat < i ; repeat++)
        {

            for (int spaceLength = 0; spaceLength < (i - repeat - 1); spaceLength++)
            {
                Console.Write(" ");
            }
            for (int spaceLength = (i - repeat - 1); spaceLength < i; spaceLength++) { 
                Console.Write("#");
            }

            Console.Write("\n");
        }

    }
}