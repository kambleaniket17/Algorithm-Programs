// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Binary.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Operations on Binary Digits
    /// Swapping
    /// </summary>
    public class Binary
    {
        /// <summary>
        /// Swaps the nibbles.
        /// </summary>
        public static void SwapNibbles()
        {
            string result=Input.InputToBinary();
            int result1 = Convert.ToInt32(result);
            Console.WriteLine(((result1 & 0x0F) << 4 |
             (result1 & 0xF0) >> 4));
            //int result2 = result1 >> 4;
            //int result3 = result1 << 4;
            //int result4 = result3 + result2;
            //Console.WriteLine(result4);

        }
    }
}
