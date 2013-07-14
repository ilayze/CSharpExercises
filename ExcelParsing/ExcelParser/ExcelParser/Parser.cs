using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToExcel;

namespace ExcelParser
{
    class Parser
    {
        string excelFilePath;
        string workSheetName;

        const string defaultWorkSheet = "Services_Details";

        const string ChannelNumberColumn = "Ch# Number";
        const string ChannelNameColumn = "Channel Name";
        const string FixedChangeableColumn = "Fixed / Changeable";

        public Parser(string excelPath)
            :this(excelPath, defaultWorkSheet)
        {}
        
        public Parser(string excelPath,string workSheetName)
        {
            excelFilePath = excelPath;
            this.workSheetName = workSheetName;

        }

        public void Parse(QueryBuilder builder)
        {
            var excel = new ExcelQueryFactory(excelFilePath);
            SetMapping(excel);
            //SetTransformation(excel);

            var ChannelsMetadataList = from metadata in excel.Worksheet<ChannelMetadataStrings>(workSheetName)
                        select metadata;

            ChannelsMetadataList=builder.ExecuteQuery(ChannelsMetadataList);
           
            foreach (var channel in ChannelsMetadataList)
            {
                Console.WriteLine(channel.ChannelName);
            }

        }



        private void SetMapping(ExcelQueryFactory excel)
        {
            excel.AddMapping<ChannelMetadataStrings>(x => x.ChannelNumber, ChannelNumberColumn);
            excel.AddMapping<ChannelMetadataStrings>(x => x.ChannelName, ChannelNameColumn);
            excel.AddMapping<ChannelMetadataStrings>(x => x.Fixed, FixedChangeableColumn);
            excel.AddMapping<ChannelMetadataStrings>(x => x.VideoEncoding, "Video Encoding");
            excel.AddMapping<ChannelMetadataStrings>(x => x.Static, "Static / Dynamic");
            excel.AddMapping<ChannelMetadataStrings>(x => x.ClearOrScrambled, "Clear / Scrambled");
            excel.AddMapping<ChannelMetadataStrings>(x => x.EventsLength, "Events Length");

        }

        private void SetTransformation(ExcelQueryFactory excel)
        {
            excel.AddTransformation<ChannelMetadataStrings>(x => x.Fixed, (t) => t == "Fixed" ? true : false);
        }
    }


    public class Person
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string hobbit { get; set; }
    }

    public enum hobbit
    {
        sport,
        none
    }


}
