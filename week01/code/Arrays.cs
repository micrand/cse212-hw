public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //first: Create a new doubles array, it's "length" will be the size
        //then: Use a for loop to get the array data
        //then: Start with index = 0 to the length of the array, and loop through the array
        //then: Store the result of multiply of the number in the array
        //finally: Return the array as output

        double[] results = new double[length];
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i+1);
        }
        return results; 
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> dataList, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //first: Calculate the number of elements in dataList and assign it to a variable
        //then: Split the data into two parts
        //then: Clear the dataList to prepare for the new order of the data
        //finally: Join the two lists into the original list

        int count = dataList.Count;

        List<int> lastPart = dataList.GetRange(count-amount, amount);

        List<int> firstPart = dataList.GetRange(0, count-amount);

        dataList.Clear();

        dataList.AddRange(lastPart);
        dataList.AddRange(firstPart);
    }
}
