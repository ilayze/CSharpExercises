using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace ExcelParser
{
    public class QueryBuilder
    {
        private Dictionary<string, string> queryFilters;

        public string ChannelNumber {  set { queryFilters["ChannelNumber"] = value; } }
        public string ChannelName { set { queryFilters["ChannelName"] = value; } }

        public QueryBuilder()
        {
            queryFilters = new Dictionary<string, string>();
        }

        internal IQueryable<ChannelMetadataStrings> ExecuteQuery(IQueryable<ChannelMetadataStrings> ChannelsMetadataList)
        {

            IQueryable<ChannelMetadataStrings> channels = ChannelsMetadataList;
            foreach (var filter in queryFilters)
            {
                
                ParameterExpression pe = Expression.Parameter(typeof(ChannelMetadataStrings), "channel");

                Expression left = Expression.Property(pe, filter.Key);
                Expression right = Expression.Constant(filter.Value);
                Expression predicateBody = Expression.Equal(left, right);

                MethodCallExpression whereCallExpression = Expression.Call(typeof(Queryable), "Where", new Type[] { channels.ElementType }
                    , channels.Expression, Expression.Lambda<Func<ChannelMetadataStrings, bool>>(predicateBody,new ParameterExpression[]{pe}));
                channels = channels.Provider.CreateQuery<ChannelMetadataStrings>(whereCallExpression);
            }

            return channels;
        }
    }
}
