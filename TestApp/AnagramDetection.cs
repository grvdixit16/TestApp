using System;

public class AnagramDetection
{ //An anagram is a word or phrase formed by rearranging the letters of another, typically using all the original letters exactly once. This problem tests a candidate's ability to manipulate strings and use collections.

    public bool AreAnagrams(string s1, string s2)
    {
        // If the lengths are different, they can't be anagrams
        if (s1.Length != s2.Length)
            return false;

        // Convert both strings to character arrays and sort them
        char[] arr1 = s1.ToLower().ToCharArray();
        char[] arr2 = s2.ToLower().ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);

        // If the sorted arrays are identical, they are anagrams
        return new string(arr1) == new string(arr2);
    }
}
