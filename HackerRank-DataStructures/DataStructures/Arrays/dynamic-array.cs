namespace HackerRank_DataStructures.DataStructures.Arrays
{
    class DynamicArray
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            // Initialize the lastAnswer to 0.
            int lastAnswer = 0;

            // Initialize the list of n empty sequences (arrays).
            // A List<List<int>> is used to represent the dynamic array where 
            // each inner list is a sequence.
            List<List<int>> seqList = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                seqList.Add(new List<int>());
            }

            // List to store the results of Query Type 2.
            List<int> results = new List<int>();

            // Process each query.
            foreach (var query in queries)
            {
                int queryType = query[0];
                int x = query[1];
                int y = query[2];

                // Calculate the index for the sequence list.
                // Formula: ((x XOR lastAnswer) % n)
                int index = (x ^ lastAnswer) % n;

                if (queryType == 1)
                {
                    // Query Type 1: Append y to the sequence at index.
                    // seqList[index].append(y)
                    seqList[index].Add(y);
                }
                else if (queryType == 2)
                {
                    // Query Type 2: Assign a value from the sequence to lastAnswer.

                    // 1. Get the sequence (seq).
                    List<int> seq = seqList[index];

                    // 2. Calculate the element index within the sequence.
                    // Formula: y % size(seq)
                    int elementIndex = y % seq.Count;

                    // 3. Update lastAnswer.
                    // lastAnswer = seq[elementIndex]
                    lastAnswer = seq[elementIndex];

                    // 4. Store the new lastAnswer in the results list.
                    results.Add(lastAnswer);
                }
            }

            // Return the list of all lastAnswer values recorded from Query Type 2.
            return results;
        }

    }
}
