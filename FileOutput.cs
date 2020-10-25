using System;
using System.IO;

public class FileOuput
{
    StreamWriter output = null;
    private string fileName;

    public FileOuput(string fileName)
    {
        this.fileName = fileName;
        try
        {
            output = new StreamWriter(new BufferedStream(File.Open(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite)));
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine($"File open error: {fileName} {e}");
        }
    }

    public void FileWrite(String line) 
    {
        try 
        {
            output.WriteLine(line);
        } 
        catch (Exception e) 
        {
            Console.WriteLine($"File Write Error: {fileName} {e}");
        }
    }

    public void FileClose() 
    {
        if (output != null) 
        {
            try 
            {
                output.Close();
            } 
            catch (IOException e) 
            {
                Console.WriteLine(e);
            }
        }

    }
}