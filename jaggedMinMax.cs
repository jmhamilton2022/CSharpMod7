/***************************************************************
* Name         : Console App: Max and Min in Jagged Arrays
* Author       : Jessica Hamilton
* Created      : 03/03/2024
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 11
* IDE          : Visual Studio 2022 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : returns the lowest and highest miles between cities
*                      Input :  none
*                      Output: items in an array
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/








namespace Module7
{
    internal class jaggedMinMax
    {

       public static int Min(int[] mileageTable)
        { 
            int min = mileageTable[0];

            foreach (int mileSet in mileageTable) 
            {
                if (mileSet < min)
                {
                    min = mileSet;
                }
            }

            return min;
        }


        public static int Max(int[] mileageTable)
        {
            int max = mileageTable[0];

            foreach (int mileSet in mileageTable)
            {
                if (mileSet > max)
                {
                    max= mileSet;
                }
            }

            return max;
        }


        static void Main(string[] args)
        {
            string[] cityList = { "Edinburgh", "Birmingham", "Cardiff",
                                    "Dover", "Leeds", "Liverpool", "London", "Manchester",
                                    "NewCastle", "York" };


            int[][] mileageTable = new int[10][];
            mileageTable[0] = new int[] { 0 };
            mileageTable[1] = new int[] { 290 };
            mileageTable[2] = new int[] { 373, 102 };
            mileageTable[3] = new int[] { 496, 185, 228 };
            mileageTable[4] = new int[] { 193, 110, 208, 257 };
            mileageTable[5] = new int[] { 214, 90, 165, 270, 73 };
            mileageTable[6] = new int[] { 412, 118, 150, 81, 191, 198 };
            mileageTable[7] = new int[] { 222, 86, 173, 285, 41, 34, 201 };
            mileageTable[8] = new int[] { 112, 207, 301, 360, 94, 155, 288, 141 };
            mileageTable[9] = new int[] { 186, 129, 231, 264, 25, 97, 194, 66, 82 };


            for (int i = 0; i < cityList.Length; i++)
            {
                Console.Write(cityList[i] + " ");
            }

            Console.WriteLine();



            for (int i = 0; i < mileageTable.Length; i++)
            {
                for (int j = 0; j < mileageTable[i].Length; j++)
                {
                    Console.Write(mileageTable[i][j] + "\t");
                }

                Console.WriteLine();
            }

            int minDistance = Min(mileageTable[7]);
            int minCityIndex = Array.IndexOf(mileageTable[7], minDistance) + 1;
            Console.WriteLine($"The closest city is {cityList[minCityIndex]} at {minDistance} miles.");

            int maxDistance = Max(mileageTable[7]);
            int maxCityIndex = Array.IndexOf(mileageTable[7], maxDistance) + 1;
            Console.WriteLine($"The closest city is {cityList[maxCityIndex]} at {maxDistance} miles.");
        }
    }
}
