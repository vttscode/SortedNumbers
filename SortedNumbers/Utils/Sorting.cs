namespace SortedNumbers.Utils
{
    public class Sorting : ISorting
    {

        public string BubbleSort(string value)
        {
            string[] temp = value.Split(' ');
            int[] intArray = Array.ConvertAll(temp, int.Parse);

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = 0; j < intArray.Length - i - 1; j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int swap = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = swap;
                    }
                }
            }

            return string.Join(" ", intArray);
        }

        public string SimpleSort(string val)
        {

            string[] temp = val.Split(' ');
            int[] intArray = Array.ConvertAll(temp, int.Parse);

            for (int i = 0; i < intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        int swap = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = swap;
                    }
                }
            }

            return string.Join(" ", intArray);
        }


    }
}
