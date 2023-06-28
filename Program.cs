// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
string fileName = @"C:\FileLogger\logger.txt";
System.IO.Directory.CreateDirectory("C:\\FileLogger");

using (FileStream fs = File.Create(fileName))
{
    // Add some text to file    
    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
    fs.Write(title, 0, title.Length);
    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
    fs.Write(author, 0, author.Length);
}

