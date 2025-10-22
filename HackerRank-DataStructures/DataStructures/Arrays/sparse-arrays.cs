using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_DataStructures.DataStructures.Arrays
{
    class SparseArrays
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY stringList
         *  2. STRING_ARRAY queries
         */

        public static List<int> matchingStrings(List<string> stringList, List<string> queries)
        {
            List<int> returnArray = new();

            for (int i = 0; i < queries.Count(); i++)
            {
                int instances = 0;
                instances = stringList.FindAll(item => item == queries[i]).Count();
                returnArray.Add(instances);
            }

            return returnArray;
        }

    }
}
