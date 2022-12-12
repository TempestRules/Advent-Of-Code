using System.Collections;

namespace AdventOfCode.Day_1
{
    internal class Reader
    {
        private readonly string file = "C:\\Users\\Victor\\Documents\\C#\\AdventOfCode\\Day_1\\Calories.txt";

        public ArrayList GetElfsFromFile()
        {

            ArrayList elfs = new ArrayList();

            if (File.Exists(file))
            {
                Console.WriteLine("The File Exists");

                Elf elf = new Elf("Elf " + "0");

                // Read the file present in the path
                using (StreamReader sr = new StreamReader(file))
                {

                    // Iterating the file
                    while (sr.Peek() >= 0)
                    {

                        string line = sr.ReadLine();

                        if (line.Equals("")) {
                            elfs.Add(elf);

                            elf = new Elf("Elf " + elfs.Count);

                        } else
                        {
                            elf.addCalories(line);
                        }


                       
                    }
                }

            }

            return elfs;
        }
    }
}
