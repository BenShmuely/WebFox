using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace WebFox.Controllers.PathTraversal
{
    public class PathTraversalTest3
    {
        static readonly string rootFolder = @"C:\Temp\Data\"; 
        
        [HttpGet("{userInput}")]
        static void Test(string userInput)    
        {
            var fullPath = Path.Combine(rootFolder, userInput);
            var reader = new StreamReader(fullPath);
            reader.ReadToEnd();
        }
    }
}