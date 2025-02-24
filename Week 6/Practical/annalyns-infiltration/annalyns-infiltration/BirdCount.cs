/* 
 * Filename: BirdCount.cs
 * Description: A skeleton class for a C# practical exercise covering basic programming tasks
 * such as declaring variables, methods, returning data from methods. 
 * 
 * Excercise adapted from https://github.com/exercism/csharp/tree/main/exercises/concept/bird-watcher
 */

/*
* Instructions:
* You're an avid bird watcher that keeps track of how many birds have visited your garden 
* in the last seven days. You have six tasks, all dealing with the numbers of birds that 
* visited your garden. 
*/


using System.Runtime.CompilerServices;

namespace annalyns_infiltration;
public class BirdCount
{
    private readonly int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    /// <summary>
    /// The <c>LastWeek</c> method returns an array containing last weeks count which was 
    /// [0, 2, 5, 3, 7, 8, 4].
    /// </summary>
    /// <returns>An array of seven integers.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public static int[] LastWeek()
    {
        // TODO: Implement the 'LastWeek()' method
        int[] lastWeek = [0, 2, 5, 3, 7, 8, 4];
        return lastWeek;
    }

    /// <summary>
    /// The <c>Today</c> method returns the number of birds that visited today. The counts are 
    /// ordered by day, with the first element being the count of the oldest day, and the 
    /// last element being today's count.
    /// </summary>
    /// <returns>An integer representing the number of birds that visisted today.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int Today()
    {
        // TODO: Implement the 'Today()' method
        return _birdsPerDay[_birdsPerDay.Length - 1];
    }

    /// <summary>
    /// The <c>IncrementTodaysCount</c> method increments the current count for the number of 
    /// birds that visited today by 1.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public void IncrementTodaysCount()
    {
        // TODO: Implement the 'IncrementTodaysCount()' method
        _birdsPerDay[_birdsPerDay.Length - 1] += 1;
    }

    /// <summary>
    /// The <c>HasDayWithoutBirds</c> method returns <c>true</c> if there was one or more days this week where
    /// no birds visited the garden otherwise <c>false</c>false.
    /// </summary>
    /// <returns>Returns <c>true</c> if there was a day where no birds visited; otherwise <c>false</c>.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool HasDayWithoutBirds()
    {
        // TODO: Implement the 'HasDayWithoutBirds()' method
        Boolean noBirds = false;

        for(int i = 0; i < _birdsPerDay.Length; i++)
        {
            if (_birdsPerDay[i] == 0)
            {
                noBirds = true; break;
            }
        }

        return noBirds;

    }

    /// <summary>
    /// The <c>CountForFirstDays</c> method returns the number of birds that have visited your 
    /// garden from the start of the week, but limit the count to the specified number of days
    /// from the start of the week.
    /// </summary>
    /// <param name="numberOfDays"></param> An integer representing the number of days from the
    /// start of the week to count from.
    /// <returns>An <c>int</c> representing the number of birds that visited during the days.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int CountForFirstDays(int numberOfDays)
    {
        // TODO: Implement the 'CountForFirstDays()' method
        int numberOfBirds = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            numberOfBirds += _birdsPerDay[i];
        }
        return numberOfBirds;

    }
    /// <summary>
    /// The <c>BusyDays</c> method counts the number of days over the last week where more
    /// than five birds visited the garden.
    /// </summary>
    /// <returns>an <c>int</c> representing the number of days over the last week where
    /// 5 or more birds visited the garden.</returns>
    /// <exception cref="NotImplementedException"></exception>
    public int BusyDays()
    {
        // TODO: Implement the 'BusyDays()' method
        int noOfBusyDays = 0;

        for(int i = 0; i < _birdsPerDay.Length; i++)
        {
            if (_birdsPerDay[i] >= 5)
            {
                noOfBusyDays++;
            }
        }

        return noOfBusyDays;
    }

}


