
//www.hackerrank.com/challenges/mini-max-sum/problem
using System.Globalization;

namespace TimeConversion;
class TimeConversion
{
    public static void Main()
    {

        Console.WriteLine(timeConversion("02:34:50PM"));
    }


    public static string timeConversion(string s)
    {
        String Time = "";


        String[] HoursAndMinutesAndSeconds = s.Split(":");

        if (s.ToLower().Contains("am"))
        {
               
            if (HoursAndMinutesAndSeconds[0] == "12") {
                HoursAndMinutesAndSeconds[0] ="00";
            }
        }
        else {
            HoursAndMinutesAndSeconds[0] = (int.Parse(HoursAndMinutesAndSeconds[0]) + 12) + "";
        }

        return HoursAndMinutesAndSeconds[0]+":"+ HoursAndMinutesAndSeconds[1] + ":" + HoursAndMinutesAndSeconds[2].Substring(0,2);
    }
}