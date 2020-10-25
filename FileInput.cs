using System;
using System.IO;

public class FileInput
{
    private StreamReader input = null;
    private string fileName;

    public FileInput(string fileName)
    {
        this.fileName = fileName;
        try {
            input = new StreamReader(new BufferedStream(File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)));
        } catch(FileNotFoundException e) {
            Console.WriteLine($"File open error: {fileName} {e}");
        }
    }

    public void FileRead() 
    {
        string line;
        try {
            while ((line = input.ReadLine()) != null) {
                Console.WriteLine(line);
            }
        } catch (Exception e) {
            Console.WriteLine($"File Write Error: {fileName} {e}");
        }
    }

    public string FileReadLine() 
    {
        try {
            string line = input.ReadLine();
            return line;
        } catch (Exception e) {
            Console.WriteLine($"File Write Error: {fileName} {e}");
            return null;
        }
    }

    public void FileClose() {
        if (input != null) {
            try {
                input.Close();
            } catch (IOException e) {
                Console.WriteLine(e);
            }
        }

    }
}