// See https://aka.ms/new-console-template for more information
using System.Text;
using TSFileCreator;

Console.WriteLine("Hello, World!");
string fileName = @"C:\FileLogger\logger.txt";
System.IO.Directory.CreateDirectory("C:\\FileLogger");
creator cr = new creator();
using (FileStream fs = File.Create(fileName))
{
    // Add some text to file    
    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
    fs.Write(title, 0, title.Length);
    byte[] author = new UTF8Encoding(true).GetBytes("Yola!!" + cr.someValue);
    fs.Write(author, 0, author.Length);
    Console.WriteLine("File created");
}

