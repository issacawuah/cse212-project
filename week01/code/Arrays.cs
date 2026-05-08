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
        // Create a new array with the double required lenght.
        // Use a for loop to go through each position in the array.
        // For each index, calculate the multiple of the number.
        // store the multple in the array at the correct index.
        // return the complete array.
        double[] results = new double[length];
        for (int i = 0; i < length; i++)
        {
            results[i] = number * (i + 1);
        }

        return results; // replace this return statement with your own

    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Find the position where the list should be split. This will be the length of the list minus the amount to rotate. 
        // Get the portion from the split point to the end of the list.
        // get the portion rom the beginning of the list to the split point.
        // Clear the original list.
        // Add the right the portion to the list first.
        // Add the left portion to the list second.
        // the original list is now rotted to the right.
        int splitpoint = data.Count - amount;
        List<int> leftside = data.GetRange(splitpoint, amount);
        List<int> rightside = data.GetRange(0, splitpoint);
        data.Clear();
        data.AddRange(leftside);
        data.AddRange(rightside);
    }
}
