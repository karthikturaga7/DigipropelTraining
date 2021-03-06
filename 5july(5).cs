using System;  
                      
public class CountWordFile  
{      
    public static void Main()  
    {  
        String line;  
        int count = 0;  
          
        //Opens a file in read mode  
        System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\user\Desktop\textfile.txt");    
              
        //Gets each line till end of file is reached  
        while((line = file.ReadLine()) != null){  
            //Splits each line into words  
            String[] words= line.Split(' ');  
            //Counts each word  
            count = count + words.Length;  
        }  
          
        Console.WriteLine("Number of words present in given file: " + count);  
        file.Close();  
    }  
}  
**//
  Expected Output
  Number of words present in a given file 54
  **//
