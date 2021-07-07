using System;

 public class PhotoBook // created class called  photobook
 {
	 protected int numPages;//used protected class instead of private
	 public int GetNumberPages()
	 {
		 return numPages;
	 }
	 public PhotoBook()// default consturctor defined
	 {
		 numPages = 16;
	 }
	 public PhotoBook(int numPages)// It is a parameterized constructor where we specfic no.of pages 
	 {
		 this.numPages=numPages;
	 }
 }
public class BigPhotoBook :PhotoBook // used inhertiance concept for BigPhotoBook
{
	public BigPhotoBook()// constructor defined
	{
	 numPages = 64;
	}
}
public class PhotoBookTest
{
	public static void Main()// main method
	{
		PhotoBook book1= new PhotoBook();
		Console.WriteLine(book1.GetNumberPages());
		
		PhotoBook book2= new PhotoBook(24);
		Console.WriteLine(book2.GetNumberPages());
		
		BigPhotoBook book3= new BigPhotoBook();
		Console.WriteLine(book3.GetNumberPages());
	} 
}
      

Expected Output:
16
24
64  