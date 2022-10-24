﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTrainer
{
    internal class Tools
    {
        public String GenerateDecimal()
        {
            Random random = new Random();
            List<String> characters = new List<String>();

            int valueOne;
            char valueTwo;
            String deweyValue;

            for (int i = 0; i < 3; i++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            characters.Add(".");

            for (int y = 0; y < 3; y++)
            {
                characters.Add(random.Next(0, 9).ToString());
            }

            characters.Add(" ");

            for (int x = 0; x < 3; x++)
            {
                valueOne = random.Next(65, 90);
                valueTwo = (char)valueOne;
                characters.Add(valueTwo.ToString());
            }

            deweyValue = String.Join("", characters);

            return deweyValue;
        }
    }
}
