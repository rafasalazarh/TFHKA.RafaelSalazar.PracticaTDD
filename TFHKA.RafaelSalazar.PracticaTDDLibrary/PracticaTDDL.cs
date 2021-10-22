using System;

namespace TFHKA.RafaelSalazar.PracticaTDDLibrary
{
    public class PracticaTDDL
    {
        public static string GetBigger(int input1, int input2)
        {
            if (input1 > input2)
                return "El primero es el mayor";

            if (input2 > input1)
                return "El segundo es el mayor";

            return "";
        }

        public static int GetSum(int input1, int input2)
        {
            return input1 + input2;
        }

        public static int GetSubstraction(int input1, int input2)
        {
            return input1 - input2;
        }

        public static int GetMultiply(int input1, int input2)
        {
            return input1 * input2;
        }
    }
}
