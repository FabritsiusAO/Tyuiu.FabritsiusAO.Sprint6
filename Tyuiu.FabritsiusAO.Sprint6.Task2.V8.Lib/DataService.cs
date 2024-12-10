﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FabritsiusAO.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            int x;
            for (x = startValue; x <= stopValue; x++)
            {
                y = Math.Cos(2 * x) + (Math.Sin(x)) / (x + 2.5) + 2 * x;
                valueArray[count] = Math.Round(y,2);
                count++;
                if (y == double.NaN || y == double.PositiveInfinity || y == double.NegativeInfinity)
                {
                    y = 0;
                }
            }

            return valueArray;
        }
    }
}