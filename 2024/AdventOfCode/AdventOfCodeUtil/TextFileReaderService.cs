namespace AdventOfCodeUtil
{
    public class TextFileReaderService
    {
        public static List<string> ReadTextFile(string filePath)
        {
            var lines = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        lines.Add(line!);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }

            return lines;
        }
    }
}
