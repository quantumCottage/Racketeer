using System;

namespace Racketeer.Code.Utility;

public class Toolbox
{
    public static int Clamp(int value, int min, int max)
    {

        if (min > max)
        {
            throw new ArgumentOutOfRangeException("The value of 'min' is greater than the value of 'max'.");
        }

        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        else
        {
            return value;
        }
    }
    
    public static float Clamp(float value, float min, float max)
    {

        if (min > max)
        {
            throw new ArgumentOutOfRangeException("The value of 'min' is greater than the value of 'max'.");
        }

        if (value < min)
        {
            return min;
        }

        if (value > max)
        {
            return max;
        }

        else
        {
            return value;
        }
    }
    
}