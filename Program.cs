﻿public static class Validators
{
    public static int LargestRelativeFirst(int a, int b, int c)
    {
        if (a < b)
            return b;
        else if (a > c)
            return c;
        else
            return a;
    }
}