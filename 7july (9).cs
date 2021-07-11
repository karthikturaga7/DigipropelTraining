using System;
using System.IO;
class ReadFriendRecords
{
    public static void Main()
    {
        //the path of the file
        FileStream inFile = new FileStream(@"C:\Users\user\Desktop\textfile.txt", FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(inFile);
        string record;
        string input;
        Console.Write("Enter the word in the line to  find :\n");
        input = Console.ReadLine();
        try
        {
            //the program reads the record and displays it on the screen
            record = reader.ReadLine();
            while (record != null)
            {
                if (record.Contains(input))
                {
                    Console.WriteLine(record);
                }
               
                
                    record = reader.ReadLine();
                
            }
        finally
        {
            //after the record is done being read, the progam closes
            reader.Close();
            inFile.Close();
        }
        
        
        Console.ReadLine();
    }
}
    **Expected Output
        Enter Friend's Birth Month >>present
        In the program it is present for the pionters.
            **//
        
