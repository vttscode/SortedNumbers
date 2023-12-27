namespace SortedNumbers.Utils
{
    public class IOFiles : IIOFiles
    {
        public void SaveToFile(string result)
        {
            if (File.Exists(@"c:\temp\Result.txt"))
            {
                File.Delete(@"c:\temp\Result.txt");
            }
            string path = @"c:\temp\Result.txt";

            // This text is added only once to the file.
            using StreamWriter writer = new StreamWriter(path);
            writer.WriteLine(result);
        }
        public string ReadFromFile()
        {

            string path = @"c:\temp\Result.txt";
            string str = "";
            try
            {
                StreamReader streamReader1 = new StreamReader(path);
                using StreamReader streamReader = streamReader1;
                str = streamReader.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return str;
        }

    }
}
