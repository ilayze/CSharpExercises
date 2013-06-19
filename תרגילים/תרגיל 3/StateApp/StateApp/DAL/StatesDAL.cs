using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using StateApp.Entities;

namespace StateApp.DAL
{
    public class StatesDAL
    {
        private const string ConnString =
            @"Data Source=Hadash-PC;" +
            "Initial Catalog=StatesDB;Integrated Security=True";

        public void ConnectDb()
        {
            DbConnection con=new SqlConnection(ConnString);
            con.Open();
        }

        public State GetState(string stateName)
        {
            using (DbConnection conn = new SqlConnection(ConnString))
            using (DbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT * " +
                    "FROM States "+
                    "WHERE stateName=@state";
                DbParameter stateParam = cmd.CreateParameter();
                stateParam.ParameterName = "@state";
                stateParam.Value = stateName;
                cmd.Parameters.Add(stateParam);

                conn.Open();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                 bool res= reader.Read();
                    if (res)
                    {
                        State s = new State(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3));
                        return s;
                    }
                    return null;
                }

            }
           
        }

        public void AddState(State s)
        {
           
             using (DbConnection conn = new SqlConnection(ConnString))
             using (DbCommand cmd = conn.CreateCommand())
             {
                 cmd.CommandText = "INSERT INTO States VALUES(@statename,@capital,@population,@flagFile)";

                 DbParameter stateParam1 = cmd.CreateParameter();
                 stateParam1.ParameterName = "@statename";
                 stateParam1.Value = s.StateName;
                 cmd.Parameters.Add(stateParam1);

                 DbParameter stateParam2 = cmd.CreateParameter();
                 stateParam2.ParameterName = "@capital";
                 stateParam2.Value = s.CapitalCity;
                 cmd.Parameters.Add(stateParam2);

                 DbParameter stateParam3 = cmd.CreateParameter();
                 stateParam3.ParameterName = "@population";
                 stateParam3.Value = s.Population;
                 cmd.Parameters.Add(stateParam3);

                 DbParameter stateParam4 = cmd.CreateParameter();
                 stateParam4.ParameterName = "@flagFile";
                 stateParam4.Value = s.StateFlagFile;
                 cmd.Parameters.Add(stateParam4);

                 conn.Open();
                 cmd.ExecuteNonQuery();
             }


        }

        public LinkedList<State> GetAllStates()
        {
            using (DbConnection conn = new SqlConnection(ConnString))
            using (DbCommand cmd = conn.CreateCommand())
            {
                cmd.CommandText =
                    "SELECT * " +
                    "FROM States ";

                conn.Open();
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    var statesList = new LinkedList<State>();

                    while (reader.Read())
                    {
                            var s = new State(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetInt32(2),
                            reader.GetString(3));

                        statesList.AddLast(s);

                    }
                    if (statesList.Count > 0)
                    {
                        return statesList;
                    }
                    return null;
                }

                }


            }
    }
}
