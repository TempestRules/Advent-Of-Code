using System.Collections;

namespace AdventOfCode.Day_2
{
    internal class Reader_2
    {
        private readonly string file = "C:\\Users\\Victor\\Documents\\C#\\AdventOfCode\\Day_2\\moves.txt";

        public ArrayList GetFile()
        {

            ArrayList lines = new ArrayList();

            if (File.Exists(file))
            {
                Console.WriteLine("The File Exists");

                // Read the file present in the path
                using (StreamReader sr = new StreamReader(file))
                {

                    // Iterating the file
                    while (sr.Peek() >= 0)
                    {
                        lines.Add(sr.ReadLine());   
                    }
                }

            }

            return lines;
        }
    }
}
