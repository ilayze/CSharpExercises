using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelParserLowLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Hadash\Documents\Visual Studio 2010\Projects\ExcelParsing\ExcelParser\ExcelParser\ExcelFiles\Book1.xlsx";
            Parser parser = new Parser(path);
            parser.Parse();
        }
    }
}
