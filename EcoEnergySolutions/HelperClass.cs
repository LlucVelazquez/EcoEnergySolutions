﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEnergySolutions
{
    public static class HelperClass
    {

        public static int ValidarNum(string input)
        {
            int num = 0;
            try
            {
                num = int.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }
        public static float ValidarNumFloat(string input)
        {
            float num = 0;
            try
            {
                num = float.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return num;
        }

    }
}
