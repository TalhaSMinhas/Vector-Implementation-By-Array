using System;

namespace VectorImplemenatationByArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
        }
        
         static void PrintArray(int[] nums)
        {
            foreach (var i in nums)
            {
                Console.WriteLine(i);
            }
        }
        
        //push to back
        static int[] Push(int[] nums, int n)
        {
            //get size of current array
            int length = nums.Length;
            
            //add 1 to size and create ne array of updated size
            int newLength = length + 1;
            int[] temp = new int[newLength];

            //copy old array elements to new array
            for (int i = 0; i < length; i++)
            {
                temp[i] = nums[i];
            }

            // add new array elements
            temp[newLength-1] = n;
            
            return temp;
        }
        
        //pop from back
        static int[] Pop(int[] nums)
        {
            //get length of current array
            int length = nums.Length;
            
            //set last element of array to zero, essentially deleting it
            nums[length - 1] = 0;
            
            //creating new array of smaller size
            int[] temp = new int[length - 1];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = nums[i];
            }

            return temp;
        }
        
        //push to front
        static int[] PushFront(int[] nums, int n)
        {
            //dertermine current array length
            int length = nums.Length;
            
            //create new array with bigger size 
            int[] temp = new int[length + 1];
            
            //set new value to fron tof array
            temp[0] = n;
            
            //copy over old values
            for (int i = 1; i < length; i++)
            {
                temp[i] = nums[i];
            }

            return temp;
        }

        //pop from front
        static int[] PopFront(int[] nums)
        {
            //delete the front element
            nums[0] = 0;
            
            // create a new array for remaining elements to be copied to
            int[] temp = new int[nums.Length - 1];

            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = nums[i + 1];
            }

            return temp;
        }

        static int[] Reverse(int[] nums)
        {
            //create new array of same size
            int[] temp = new int[nums.Length];
            
            //time to populate new array
            for (int i = (nums.Length - 1); i >= 0; i--)
            {
                temp[Math.Abs(i - (nums.Length - 1))] = nums[i];
            }

            return temp;
        }
    }
}