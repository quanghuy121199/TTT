using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTT_Practice
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        private DataProvider() { }
        private static string getConString()
        {
            return @"Data Source= HUYLE; Initial Catalog=TTTHomework; User ID=sa; Password=huy121199";
        }
        public DataTable excuteReader(string query)
        {
            string conString = getConString();
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                data.Load(reader);
            }
            connection.Close();
            return data;
        }
        public DataTable excuteQuery(string query, object[] parameter = null)
        {
            string conString = getConString();
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if(parameter != null)
            {
                string[] temp = query.Split(' ');
                List<string> listPara = new List<string>();
                foreach(string item in temp)
                {
                    if (item[0] == '@')
                    {
                        listPara.Add(item);
                    }
                }
                for(int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listPara[i], parameter[i]);
                }
            }
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                data.Load(reader);
            }
            connection.Close();
            return data;
        }
        public int excuteNonQuery(string query, object[] parameter = null)
        {
            int acceptedRows = 0;
            string conString = getConString();
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            if (parameter != null)
            {
                string[] temp = query.Split(' ');
                List<string> listPara = new List<string>();
                foreach (string item in temp)
                {
                    if (item[0] == '@')
                    {
                        listPara.Add(item);
                    }
                }
                for (int i = 0; i < parameter.Length; i++)
                {
                    command.Parameters.AddWithValue(listPara[i], parameter[i]);
                }
            }
            acceptedRows = command.ExecuteNonQuery();
            connection.Close();
            return acceptedRows;
        }

    }
}
