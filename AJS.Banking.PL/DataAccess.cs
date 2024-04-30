using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AJS.Banking.PL
{
    public static class DataAccess
    {
        //fields 
        private static SqlConnection? connection = null;

        // properties
        public static string XMLFilePath { get; set; } = "";

        public static string ConnectionString { get; set; } = "";


        public static void SaveToXML(Type type, object obj)
        {
            if (XMLFilePath == "") throw new Exception("XMLFilePath not set.");

            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
                writer.Close();
            }
        }

        public static object? LoadFromXML(Type type)
        {
            if (XMLFilePath == "") throw new Exception("XMLFilePath not set.");

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                object? obj = serializer.Deserialize(reader);
                reader.Close();
                return obj;
            }
        }

        private static void Connect()
        {
            if (ConnectionString == null || ConnectionString.Trim() == "")
            {
                throw new Exception("Please provide a connection string.");
            }

            if (connection == null) connection = new SqlConnection(ConnectionString);

            if (connection.State != ConnectionState.Open) connection.Open();
        }

        public static DataTable Select(string sql, List<SqlParameter>? parameters = null)
        {
            Connect();

            SqlCommand command = new SqlCommand(sql, connection);

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            CloseConnection();
            return dataTable;
        }

        public static int RunSql(string sql)
        {
            Connect();

            SqlCommand command = new SqlCommand(sql, connection);

            if (sql != null)
            {
                command.Parameters.AddRange(sql.ToArray());
            }

            int id = Convert.ToInt32(command.ExecuteScalar());

            CloseConnection();
            return id;
        }

        public static void CloseConnection()
        {
            connection?.Close();
        }
    }
}
