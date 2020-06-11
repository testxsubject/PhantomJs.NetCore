﻿using PhantomJs.NetCore;
using System;
using System.IO;

namespace Sandbox
{
  public class ExampleProgram
  {
    public static void Main(string[] args)
    {
      var currentDirectory = Directory.GetCurrentDirectory();
      var generator = new PdfGenerator();

      var htmlToConvert =
@"
<!DOCTYPE html>
<html>
<head>
<style>
// Had to use this to fix the font sizing problem in linux.
html {
    height: 0;
    transform-origin: 0 0;
    -webkit-transform-origin: 0 0;
    transform: scale(0.53);
    -webkit-transform: scale(0.53);
}
</style>
</head>
<body>
    <h1>Hello World!</h1>
    <p>This PDF has been generated by PhantomJs ;)</p>
</body>
</html>
";
      // Generate pdf from html and place in the current folder.
      var pathOftheGeneratedPdf = generator.GeneratePdf(htmlToConvert, currentDirectory);

      Console.WriteLine("Pdf generated at: " + pathOftheGeneratedPdf);
      Console.WriteLine("Press any key to close...");
      Console.ReadKey();
    }
  }
}