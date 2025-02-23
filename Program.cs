class ImageFinder
{
    public static int Main()
    {
        string percPath = @"C:\Users\Public\CS361-MS-A\text-files\percent.txt";
        if (File.Exists(percPath) == false)
        {
            Console.WriteLine("File not found.");
            return 1;
        }

        ReadFile(percPath);
        return 0;
    }

    /* ReadFile takes in the image path to pass that along to WriteFile
     * It reads in the given text file and parses the data
     * If the file is not null then WriteFile is called*/
    public static void ReadFile(string percPath)
    {
        bool worked = false;
        int imgNum = 0;

        try
        {
            using (StreamReader readIn = new StreamReader(percPath))
            {
                string newNum = readIn.ReadToEnd();
                if (newNum != null)
                {
                    imgNum = Int32.Parse(newNum);
                    worked = true;
                }
                else
                {
                    Console.Write("Null data in file.");
                }
            }
        }
        catch (Exception e)
        {
            Console.Write("Error reading the file. Error is:");
            Console.Write(e.Message);
        }

        if (worked == true)
        {
            string imgPath = @"C:\Users\Public\CS361-MS-A\text-files\image-path.txt";
            WriteFile(imgNum, imgPath);
            Console.WriteLine("Done.");
        }
    }

    /* WriteFile is passed the adjusted number and the image path
     * It writes out the full path of the image that corresponds 
     * to the image number read from the text file */
    public static void WriteFile(int newNum, string imgPath)
    {
        try
        {
            using (StreamWriter writeOut = new StreamWriter(imgPath))
            {
                string num = newNum.ToString();
                string[] paths = {@"C:\Users\Public\CS361-MS-A\images", num + ".png"};
                string fullPath = Path.Combine(paths);
                writeOut.Write(fullPath);
            }
        }
        catch (Exception e)
        {
            Console.Write("Error writing to the file. Error is:");
            Console.Write(e.Message);
        }
    }
}