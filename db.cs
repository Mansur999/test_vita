using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace test_task_vita
{
    class Db
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-ED6IAQK;Initial Catalog=hospital;Integrated Security=True");
        string sql;
        SqlCommand command;
        SqlDataReader reader;

        //открыть бд
        public void openConnection()
        {
            if (sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //закрыть бд
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //получение обьекта подключения
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }

        //вывод данных из таблицы patient в dataSet
        public DataSet getDataSet()
        {
            sql = "SELECT id FROM patient";
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlConnection);
            DataSet ds = new DataSet();
            this.openConnection();
            da.Fill(ds);
            this.closeConnection();

            return ds;
        }

        //вывод данных из таблицы по запросу patient в List<>
        public List<string[]> getDataPatient(string sql)
        {
            this.openConnection();
            command = new SqlCommand(sql, sqlConnection);
            reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            this.closeConnection();

            return data;
        }

        //вывод данных из таблицы по запросу visit в List<>
        public List<string[]> getDataVisit(string sql)
        {
            this.openConnection();
            command = new SqlCommand(sql, sqlConnection);
            reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }
            reader.Close();
            this.closeConnection();

            return data;
        }
    }
}
