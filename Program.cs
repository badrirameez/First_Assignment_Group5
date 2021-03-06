﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace First_Assignment_Group5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFirst_Assignment_Group5 - Neelima, Eric and Rameez");
            Console.WriteLine("\nEnter the Problem number(1/2/3/4/5/6) for which you want to see the solution : ");
            int qNo = Convert.ToInt32(Console.ReadLine());
            if (qNo == 1)
            {
                /* Question 1: */
                //Professor Agrawal receives an array of integer points sorted in ascending order, the task is to find the initial and final index of 
                //a given target point’s value. If the target point value is not found in the array of integers, return [-1, -1]
                //The professor had to leave for a conference at short notice and asked you to complete the task for him.He instructed you to limit the time 
                //complexity to O(n).
                //Example 1:
                //Input:  marks = [5, 6, 6, 9, 9, 12]  target = 9
                //Output: [3,4]
                //Example 2: 
                //Input: marks = [5, 6, 6, 9, 9, 12] target = 10
                //Output:[-1,-1]

                //Note: The algorithm’s runtime complexity must be O(n).

                //public int[] targetRange(int[] marks, int target)
                Console.WriteLine("\nSolution for Question 1 :");

                int x;
                // Dictionaries 
                Dictionary<int, int> numbersDictionary = new Dictionary<int, int>();

                for (int i = 0; i < 10; i++) // loop to read marks into the dictionary
                {
                    int num = i + 1;
                    Console.WriteLine("Enter marks for student number " + num + " : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    numbersDictionary.Add(i, x);
                }

                Console.WriteLine("\nNumber of Elements in the marks dictionary = " + numbersDictionary.Count());
                Console.WriteLine("\nEnter a Number to find in the marks Dictionary : ");
                int y = Convert.ToInt32(Console.ReadLine()); 

                if (numbersDictionary.ContainsValue(y)) // condition to verify if the number exists in the dictionary
                {
                    for (int index = 0; index < numbersDictionary.Count(); index++) // loop to find each occurance of y
                    {

                        if (numbersDictionary.ElementAt(index).Value == y)
                        {
                            Console.WriteLine("The index for value " + y + " is " + numbersDictionary.ElementAt(index).Key);
                        }

                    }
                }
                else // if the given number does not exist in the dictionary
                {
                    Console.WriteLine("Marks " + y + "  NOT found in the Dictionary");
                    Console.WriteLine("The index for value " + y + " is -1");
                }

            }
            else if (qNo == 2)
            {
                /* Question 2: */
                //Rocky is not aware of the inbuilt functions to split and reverse a string. He is given a string and he needs to reverse the order of 
                //characters in each word within a sentence while still preserving whitespace and initial word order. He is not allowed to use any 
                //predefined split and reverse function. He is requesting you to complete the method for him.

                //Example: 
                //Input : “University of South Florida”
                //Output: “stisverinU fo htuoS adirolF”
                //Note: Time complexity should be O(n) where n is the length of string
                //Hint: Create your own split and reverse function.
                //Public static string StringReverse(string s)
                Console.WriteLine("\nSolution for Question 2 :");
                string str = "University of South Florida";
               //string str = "ca ca";
               
                Console.WriteLine("\nThis is how the string looks like after reversing each word : \""+ StringReverse(str)+"\"");
            }
            else if (qNo == 3)
            {
                /* Question 3: */
                //Professor Stablein is given a sorted integer array.He needs to make the array elements distinct by increasing each value as needed, while 
                //minimizing the array sum.Professor Stablein thought this was an interesting exercise that the students might enjoy completing. 
                //Your job is to complete the method to print the minimum possible sum as output.
                //Example : 
                //Input : arr[] = { 2,2,3,5,6}; Output: 20
                //Explanation: Array is transformed to {2,3,4,5,6}. Sum becomes 2+3+4+5+6=20
                //Input arr[] = { 40, 40 }; Output: 81
                //Explanation: Array is transformed to {40,41}. Sum becomes 81
                //Input: arr[] = {4,5,6,9};			Output : 24
                //Explanation: As the array is sorted and has distinct elements.So result is sum of each elements in the array.

                //Time Complexity: O(n)
                //public static int minSum(int[] arr)
                Console.WriteLine("\nSolution for Question 3 :");
                Console.WriteLine("Enter the number of elements in the array");
                int nStab = Convert.ToInt32(Console.ReadLine()); //Getting the size of the integer array.
                int sumNumArrayStab = 0; //Initializing sum of the array elements as zero.
                bool cheat = false;
                if (nStab < 2) // Specifying condition to enter at least 2 number in the array.
                {
                    Console.WriteLine("Minimum array length should be geater than or equal to 2.");
                }
                else //enter this code when the array lenght is more geater than or equal to 2.
                {
                    int[] numberArrayStab = new int[nStab];

                    for (int i = 0; i < nStab; i++) //For loop to enter all numbers in the array.
                    {
                        Console.WriteLine("Enter the number at position " + i);
                        numberArrayStab[i] = Convert.ToInt32(Console.ReadLine());
                        sumNumArrayStab += numberArrayStab[i]; //Finding the sum of the array
                    }

                    Console.WriteLine("\nThe sum of the array elemets is " + sumNumArrayStab); //Show the Sum of the array.

                    Console.WriteLine("\nLength of numberArrayStab =" + numberArrayStab.Length + "\n"); //Show the Length of the array.

                    for (int i = 0; i < nStab; i++) //For loop to display all numbers in the array along with their position in the array.
                    {
                        Console.WriteLine("The number in old array at position " + i + " is " + numberArrayStab[i]);

                    }

                    cheat = MinSum(numberArrayStab, nStab); //call Method to make the array elements distinct by increasing each value as needed and find the sum
                    if (cheat)
                    {
                        Console.WriteLine("\nYou tried to cheat, your array is not sorted in ascending order."); //Display if the array is not in ascending order.
                    }

                }
            }
            else if (qNo == 4)
            {
                /* Question 4: */
                //You are given a string and your task is to sort the given string in decreasing order of frequency of occurrence of each character.
                //Example 1: 
                //Input : “Dell”					Output: “llDe”
                //Explanation:  “lleD” is also accepted.Frequency of l is 2 and other 2 characters is 1.
                //Example 2:
                //Input : eebhhh Output: hhheeb
                //Example 3: 
                //Input : yYkk Output: kkYy
                //Explanation: “Yykk” is not a valid answer as Y and y are treated as two different characters.

                //Note: The solution must use a dictionary as the primary data structure.
                //public static string FreqSort(string s)
                Console.WriteLine("\nSolution for Question 4 :");
                Console.WriteLine("Enter the String : ");
                string str = Convert.ToString(Console.ReadLine()); // get the string as input

                Console.WriteLine("The string sorted based on frequency of occurrence of each character is \"" + FreqSort(str) + "\""); //Calling the method to sort the string in decreasing order of frequency of characters

            }
            else if (qNo == 5)
            {
                /* Question 5: */
                //Rocky the Bull is new to programming and is having trouble understating the importance of time complexity. Professor Agrawal 
                //assigned you the job of explaining time complexity to Rocky with the example below.
                //Given two arrays, write a function to compute their intersection.

                //Example 1:
                //Input: nums1 = [2, 5, 5, 2], nums2 = [5, 5]
                //Output: [5,5]

                //Example 2:
                //Input: nums1 = [3, 6, 2], nums2 = [6, 3, 6, 7, 3]
                //Output: [3,6]

                //Note:
                //•	Each element in the result should appear as many times as it shows in both arrays.
                //•	The result can be in any order.
                //•	Submit 2 Solutions where time complexity of the methods is be less than O(n^2). 

                //Hint1: You can sort the both arrays and then compute the intersection, in this way you will achieve a time complexity of O(n log n). 
                //Hint2: If you make use of a dictionary, you need not sort the arrays to compute the intersection.The time complexity in this case 
                //will be O(n).

                //public static int[] Intersect1(int[] nums1, int[] nums2)
                //public static int[] Intersect1(int[] nums1, int[] nums2)
                Console.WriteLine("\nSolution for Question 5 :");
                Dictionary<int, int> dic1 = new Dictionary<int, int>();
                Dictionary<int, int> dic2 = new Dictionary<int, int>();
                int x;
                for (int i = 0; i < 5; i++) // loop to read numbers into the first dictionary
                {
                    int num = i + 1;
                    Console.WriteLine("Enter numbers for first dictionary " + num + " : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    dic1.Add(i, x);
                }
                for (int i = 0; i < 5; i++) // loop to read numbers into the second dictionary
                {
                    int num = i + 1;
                    Console.WriteLine("\nEnter numbers for second dictionary " + num + " : ");
                    x = Convert.ToInt32(Console.ReadLine());
                    dic2.Add(i, x);
                }

                Intersect1(dic1, dic2); // calling method 1

                Intersect2(dic1, dic2); // calling method 2
            }
            else if (qNo == 6)
            {
                /* Question 6: */
                //You are given an array of characters and an integer k, and are required to find out whether there are two distinct indices i and j in
                //the array such that arr[i]=arr[j] and the absolute difference between i and j is at most k.
                //Example 1: 
                //Input: arr=[a, g, h, a], k=3
                //Output= true
                //Explanation= arr[0] and arr[3] contains “a”; hence the absolute difference between 0 and 3 is 3 which is equal to 3 therefore output is true.
                //Example 2: arr=[k, y, k, k], k=1
                //Output= true
                //Example 3: 
                //Input: arr=[a, b, c, a, b, c], k=2
                //Output: false
                //Explanation= arr[0]=arr[3] but absolute difference is not at most 2 
                //           arr[1]=arr[4] but absolute difference is not at most 2
                //           arr[2]=arr[5] but absolute difference is not at most 2
                //           There fore output is false.

                //Note: The algorithm’s runtime complexity must be in the order of O(n).
                //Hint : You can make use of a dictionary to obtain the required time complexity.

                //public bool ContainsDuplicate(char[] arr, int k)

                Console.WriteLine("\nSolution for Question 6 : \n");
                Console.WriteLine("Enter the number of characters in the array : "); //Get the number of characters to insert in the array.
                int nChar = Convert.ToInt32(Console.ReadLine());

                char[] arrChar = new char[nChar]; //declaring the character array

                for (int i = 0; i < nChar; i++) //For loop to enter all characters in the array.
                {
                    Console.WriteLine("Enter the Character at position " + i);
                    arrChar[i] = Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine("\nEnter the constant \"K\" : "); //Get the "K" Value from the user
                int k = Convert.ToInt32(Console.ReadLine());

                bool soln = ContainsDuplicate(arrChar, k); //Call the method to find out whther the array and k satisfy the given condition by passing the array and the constant to it.
                if (soln)  //Display the result
                {
                    Console.WriteLine("\nThe char repeats itself in the given range.");
                }
                else
                {
                    Console.WriteLine("\nThe char does not repeats itself in the given range.");
                }

            }
            else
            {
                Console.WriteLine("Please enter a number from 1 to 6 (inclusive) ");
            }
        }
        public static string StringReverse(String str) //method for solution 2  
        {
            char[] chrArray = str.ToCharArray();
            int temp = 0;
            for (int i = 0; i <= chrArray.Length - 1; i++) //for loop to iterate up to end of the string by each character.
            {
                int count = temp; //declaring temporary variables for supporting the logic.
                int wordNum = 1; //tracks the number of words in the string.
                if (chrArray[i] == ' ' || i == chrArray.Length - 1) //to extract each word before a space(" ").
                {
                    if (i == chrArray.Length - 1) //enter condition for the last word
                    {
                        for (int j = i; j >= temp; j--)
                        {
                            if (wordNum <= (i - temp) / 2) //Reverse the last word of the string.
                            {
                                char tempWord = chrArray[count];
                                chrArray[count] = chrArray[j];
                                chrArray[j] = tempWord;
                                count++;
                                wordNum++;
                            }
                        }
                    }
                    else
                    { //enter condition for all words prior to the last word.
                        for (int j = i - 1; j >= temp; j--)
                        {

                            if (wordNum <= (i - temp) / 2) //Reverse the word prior to a space
                            {
                                char tempWord = chrArray[count];
                                chrArray[count] = chrArray[j];
                                chrArray[j] = tempWord;
                                count++;
                                wordNum++;
                            }
                        }
                    }
                    temp = i + 1;
                }

            }

            string newLine = new string(chrArray); //convert the updated character array to a string.
            return newLine; //return the updated String.
        }
        public static bool MinSum(int[] newNumArrStab, int nStab) //method fo solution 3
        {
            bool cheat = false;
            int sumNewArrayStab = newNumArrStab[0];
            for (int i = 1; i < nStab; i++) //For loop to traverse all elements of the array.
            {
                if (newNumArrStab[i] < newNumArrStab[i - 1]) //Check if array is in ascending order.
                {
                    cheat = true;
                    break;
                }
                else
                {
                    if (newNumArrStab[i] == newNumArrStab[i - 1]) //check if the current number in array is same as the previous number.
                    {
                        int j = i;
                        while (j < nStab && newNumArrStab[j] <= newNumArrStab[j - 1]) // for each number in the array check if it is less than or equal to the previous number, if yes, then increment the current number by one to make it next in sequence.
                        {
                            newNumArrStab[j] = newNumArrStab[j] + 1; //Increment the number in array if it is same as the previous number.
                            j++;
                        }

                    }
                }
                sumNewArrayStab += newNumArrStab[i]; //Find sum of the new array.
            }

            if (cheat == false)
            {
                Console.WriteLine("\n\n");
                for (int i = 0; i < nStab; i++) //For loop to display all numbers in the updated array along with their position in the array.
                {
                    Console.WriteLine("The number in new array at position " + i + " is " + newNumArrStab[i]);

                }
                Console.WriteLine("\n\nThe sum of the new array elemets is " + sumNewArrayStab + "\n"); //Show the new Sum of the array.
            }
            return cheat;
        }
        public static string FreqSort(string s) //Method for solution 4
        {
            Dictionary<char, int> d = new Dictionary<char, int>(); //Creating a dictionary to store the character and its frequency.
            foreach (char c in s) //foreach character in the string add the frequency in the dictionary.
            {
                if (d.ContainsKey(c)) //condition to increment the frequency if the char is found more than once in the disctionary.
                {
                    int freq = d[c]; //declare the fequency variable for each character.
                    d[c] = ++freq; //increments the frequency for elements occuring more than once once.
                }
                else //else condition to set feq as 1 for chars occuring once.
                {
                    d[c] = 1; //Sets the frequency as one for elements occuring only once.
                }
            }
            var sortedMap = d.OrderByDescending(c => c.Value); //sorted map to sort the characters based on the values
            System.Text.StringBuilder sb = new System.Text.StringBuilder(); //Declare a string builder 

            foreach (KeyValuePair<char, int> pair in sortedMap) //convert to string for each key value pair.
            {
                int n = pair.Value;
                while (n-- > 0)
                    sb.Append(pair.Key); //Append each key based on value.
            }
            return sb.ToString(); //returm the sorted string.
        }

        public static void Intersect1(Dictionary<int, int> firstDictionary, Dictionary<int, int> secondDictionary) //method 1 for solution 5
        {
            HashSet<int> commonValues = new HashSet<int>(firstDictionary.Values);
            commonValues.IntersectWith(secondDictionary.Values);
            var commonResultSet =
                firstDictionary
                .Where(x => commonValues.Contains(x.Value))
                .Select(x => x.Value)
                .ToList();
            Console.WriteLine("\n The First intersection result is :  ");
            commonResultSet.ForEach(Console.WriteLine);
        }
        public static void Intersect2(Dictionary<int, int> firstDictionary, Dictionary<int, int> secondDictionary)//method 2 for solution 5
        {
            HashSet<int> commonValues = new HashSet<int>(secondDictionary.Values);
            commonValues.IntersectWith(firstDictionary.Values);
            var commonResultSet =
                secondDictionary
                .Where(x => commonValues.Contains(x.Value))
                .Select(x => x.Value)
                .ToList();
            Console.WriteLine("\n The Second intersection result is :  ");
            commonResultSet.ForEach(Console.WriteLine);
        }
        public static bool ContainsDuplicate(char[] charArr, int k) //method for solution 6
        {
            Dictionary<char, int> dupChkArr = new Dictionary<char, int>(); // dictionary to store char value and last index as key value pair for each distinct char value in array

            for (int i = 0; i < charArr.Length; i++) // loop to traverse through the entered array
            {
                if (dupChkArr.ContainsKey(charArr[i])) //condition to check if the char in the array already exists in the dict as the key 
                {
                    if (i - dupChkArr[charArr[i]] <= k) // check if the difference of the current position and old position of the char is less than or equal to the constant "k"
                    {
                        return true; //Satisfies the condition hence return to as the result.
                    }
                    else
                    {
                        dupChkArr[charArr[i]] = i; // if the difference of the current position and old position of the char is more the constant "k", update the current position in the dictionary.
                    }
                }
                else
                {
                    dupChkArr.Add(charArr[i], i); // if the char doesnt exist in the dictionary then add it along with it's current position
                }
            }
            return false;// if ther are no duplicate chars within the range then just return false
        }

        
    }
}
