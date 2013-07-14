using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelParser
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\ExcelFiles\Cogeco_ITV_Stream_Current_HE_Drop_6.xls";
           // string path = @"C:\Users\Hadash\Documents\Visual Studio 2010\Projects\ExcelParsing\ExcelParser\ExcelParser\ExcelFiles\Book1.xlsx";
            Parser parser=new Parser(path);
            QueryBuilder builder = new QueryBuilder();
            builder.ChannelName = "Service_102";
            builder.ChannelNumber = "102";
            parser.Parse(builder);

            Console.ReadKey();
        }
    }
}
