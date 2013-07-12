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

        const string ChannelNumberColumn = "Ch# Number";
        const string ChannelNameColumn = "Channel Name";
        const string FixedChangeableColumn = "Fixed / Changeable";

        public Parser(string excelPath)
        {
            excelFilePath = excelPath;
        }

        public void Parse()
        {
            var excel = new ExcelQueryFactory(excelFilePath);
            SetMapping(excel);
            SetTransformation(excel);

            var ChannelsMetadataList = from metadata in excel.Worksheet<ChannelMetadata>("Services_Details")
                        select metadata;

            foreach (var channel in ChannelsMetadataList)
            {
                Console.WriteLine(channel.ChannelName);
            }


        }

        private void SetMapping(ExcelQueryFactory excel)
        {
            excel.AddMapping<ChannelMetadata>(x => x.ChannelNumber, ChannelNumberColumn);
            excel.AddMapping<ChannelMetadata>(x => x.ChannelName, ChannelNameColumn);
            excel.AddMapping<ChannelMetadata>(x => x.Fixed, FixedChangeableColumn);
            excel.AddMapping<ChannelMetadata>(x => x.VideoEncoding, "Video Encoding");
            excel.AddMapping<ChannelMetadata>(x => x.Static, "Static / Dynamic");
            excel.AddMapping<ChannelMetadata>(x => x.ClearOrScrambled, "Clear / Scrambled");
            excel.AddMapping<ChannelMetadata>(x => x.EventsLength, "Events Length");

        }

        private void SetTransformation(ExcelQueryFactory excel)
        {
            excel.AddTransformation<ChannelMetadata>(x => x.Fixed, (t) => t == "Fixed" ? true : false);
        }
    }

    public class ChannelMetadata
    {
        public int ChannelNumber { get; set; }
        public string ChannelName { get; set; }
        public bool Fixed { get; set; }
        public string VideoEncoding { get; set; }
        public string Static { get; set; }
        public string ClearOrScrambled { get; set; }
        public string EventsLength { get; set; }
        public string VideoStreamType { get; set; }

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
