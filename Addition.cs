﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlog_Demo
{
    internal class Addition
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static void Sum(int first, int second)
        {
            if (first == 0 || second == 0)
            {
                logger.Warn("please provide +ve Value");
                logger.Error("Number should not be below zero");
                logger.Debug("Debug failed");
            }

            int sum = first + second;
            logger.Debug("Debugging with sum operation successfull");
            logger.Info("sum:" + sum);

        }
        public static void pattern()
        {
            int length = 7, width = 7;
            for (int i = 1; i <= width; i++)
            {
                for(int j=1; j <= length;j++)
                {
                    if (i == 1 || i == width || j == 1 || j == length)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.Write("\n");
            }
        }
    }
}
