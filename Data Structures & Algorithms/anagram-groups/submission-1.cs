public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        // create a hashmap: key = the sorted word, value = the different anagrams from the list
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            
            // sort the word
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedWord = new string(charArray);
            
            //if the hasmap already contains the sorted word, then add the anagram to the same group
            if (anagrams.ContainsKey(sortedWord)){ 
                anagrams[sortedWord].Add(strs[i]);
            }
            else {
            //create a list and add the word into the list of the matching anagrams
            List<string> group = new List<string>();
            group.Add(strs[i]);

            //add the new key value pair into the hashmap
            anagrams.Add(sortedWord, group);
            }
        }

        // return the values of the anagram converted into List<Lists.. since its already List<...
        return anagrams.Values.ToList();


    }
}
