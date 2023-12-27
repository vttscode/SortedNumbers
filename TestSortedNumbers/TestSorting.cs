using SortedNumbers.Utils;

namespace TestSortedNumbers
{
    public class TestSorting
    {
        private const string V = "5 1 2";
        private Sorting sorting = new Sorting();      

        [Test]
        public void BubbleSortInStringFiveOneTwoResultStringOneTwoFive()
        {
            var result = sorting.BubbleSort(V);
            Assert.AreEqual("1 2 5", result);
        }


        [Test]
        public void SimpleSortInStringFiveOneTwoResultStringOneTwoFive()
        {
            var result = sorting.SimpleSort(V);
            Assert.AreEqual("1 2 5", result);
        }
    }
}
