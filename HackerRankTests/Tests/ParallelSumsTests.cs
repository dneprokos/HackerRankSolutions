﻿using HackerRankProblems.Implementations;
using HackerRankTests.Infrostructure;
using NUnit.Framework;

namespace HackerRankTests.Tests
{
    public class ParallelSumsTests : TestBase
    {
        //Have the function ParallelSums(arr) take the array of integers stored in arr
        //    and determine how they can be split into two even sets of integers each
        //    so that both sets add up to the same number.
        //    If this is impossible return -1. If it's possible to split
        //    the array into two sets, then return a string representation of the first
        //    set followed by the second set with each integer separated by a comma and
        //    both sets sorted in ascending order. The set that goes first is the set
        //with the smallest first integer.
        //    For example: if arr is [16, 22, 35, 8, 20, 1, 21, 11]
        //then your program should output 1,11,20,35,8,16,21,22
        //Input:1,2,3,4
        //Output:1,4,2,3
        //Input:1,2,1,5
        //Output:-1

        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 4, 2, 3 })]
        [TestCase(new[] { 1, 2, 1, 5 }, new[] { -1 })]
        [TestCase(new[] { 1, 2, 3, 4, 0 }, new[] { -1 })]
        public void ParallelSums_ReturnIfParallel_ShouldReturnArray(int [] initialArray, int [] expectedArray)
        {
            //Act
            int[] actualResult = ParallelSums.ReturnIfParallel(initialArray);

            //Assert
            Assert.AreEqual(expectedArray, actualResult);
        }

    }
}
