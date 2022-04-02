using System;
using Xunit;
using SystemIO;

namespace Tests
{
    public class UnitTest1
    {
        // test for challenge 4
        [Fact]
        public void FindMostDuplicate()
        {
            int[] arr = { 1, 1, 2, 3, 3, 3, 3 };
            int result = Program.Challenge04(arr);
            Assert.Equal(3, result);
        }

        [Fact]
        public void NoDuplicate()
        {
            int[] arr = { 1,8, 2,3};
            int result = Program.Challenge04(arr);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SameDuplicate()
        {
            int[] arr = { 2, 5,3,8, 2, 6,6 };
            int result = Program.Challenge04(arr);
            Assert.Equal(2, result);
        }




        // tests for challenge 5

        [Fact]
        public void FindMax()
        {
            int[] arr = { 82, 1, 500, 300 };
            int result = Program.Challenge05(arr);

            Assert.Equal(500, result);
        }

            [Fact]
            public void FindMaxNegative()
            {
                int[] arr = { -82, -1, -500, -300 };
                int result = Program.Challenge05(arr);

                Assert.Equal(-1, result);
            }


            [Fact]
            public void FindMaxSameNumbers()
            {
                int[] arr = { 5,5,5,5 }; 
                int result = Program.Challenge05(arr);

                Assert.Equal(5, result);
            }
    }
}
