namespace HackerRank_DataStructures.DataStructures.Arrays
{
    class ArrayLeftRotation
    {

        /*
         * Complete the 'rotateLeft' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER d
         *  2. INTEGER_ARRAY arr
         */

        public static List<int> rotateLeft(int d, List<int> arr)
        {
            for (int i = 0; i < d; i++)
            {
                arr.Add(arr[0]);
                arr.Remove(arr[0]);
            }
            return arr;
        }

    }
}
