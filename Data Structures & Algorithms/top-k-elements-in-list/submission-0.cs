public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        // create a dictionary of the key value pair (number, amount of apperances)
        Dictionary<int, int> listOfAp = new Dictionary<int, int>();

        // loop through the array of nums
        for (int i = 0; i < nums.Length; i++) {
            //check if list contains the key
            if (listOfAp.ContainsKey(nums[i])) {
                listOfAp[nums[i]]++;
            }
            // create a keyvaluepair
            else {
                listOfAp.Add(nums[i], 1);
            }
        }
        //sort the dictionary by value
        var orderedList = listOfAp.OrderByDescending(item => item.Value);
        // Turn it into an array instead of IEnumerable
        var freq = orderedList.ToArray();

        int[] result = new int[k];

        //Loop thorugh the k top items and insert the Key into the result array
        for (int i = 0; i < k; i++) {
           result[i] = freq[i].Key;
        }
        return result;
    }
}
