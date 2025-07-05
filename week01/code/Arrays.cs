public static class Arrays
{
   // PLAN for MultiplesOf
        // 1. Validate: length is > 0 (assignment guarantees it, but note it here).
        // 2. Create a new double[] called result whose size is 'length'.
        // 3. For i = 0 .. length - 1
        //      - The i-th multiple is number × (i + 1)
        //      - Store it in result[i]
        // 4. Return result
        //
        // Complexity: one simple loop ⇒ O(length)

    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }

    // This function rotates the list to the right by the given amount.
    public static void RotateListRight(List<int> data, int amount)
    {
        // PLAN for RotateListRight (slicing)
        // 1. Normalize: amount %= data.Count (safety)
        // 2. Extract the last 'amount' items into a new list called tail:
        //      tail = data.GetRange(data.Count - amount, amount)
        // 3. Delete those items from the end:
        //      data.RemoveRange(data.Count - amount, amount)
        // 4. Insert tail at the front:
        //      data.InsertRange(0, tail)
        // 5. Done (modifies list in-place)
        //
        // Complexity: each List operation copies/iterates at most n elements ⇒ O(n)

        amount %= data.Count;

        List<int> tail = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, tail);
    }
}