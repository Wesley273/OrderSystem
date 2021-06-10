using System.Data;
using System.Data.SqlClient;

namespace OrderSystem
{
    class DataBase
    {
        private SqlConnection connection;  //创建连接对象
        #region   打开数据库连接
        private void Open()
        {
            if (connection == null)
            {
                connection = new SqlConnection("Server=localhost;Trusted_Connection=SSPI;database=order_system");
            }
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }
        #endregion

        #region  关闭连接
        public void Close()
        {
            if (connection != null)
                connection.Close();
        }
        #endregion

        #region 释放数据库连接资源
        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
                connection = null;
            }
        }
        #endregion

        #region   传入参数并且转换为SqlParameter类型
        public SqlParameter GetSqlParameter(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            SqlParameter parameter;
            if (Size > 0)
                parameter = new SqlParameter(ParamName, DbType, Size);
            else
                parameter = new SqlParameter(ParamName, DbType);
            if (!(Value == null))
                parameter.Value = Value;
            return parameter;
        }
        #endregion

        #region   执行参数命令文本(无数据库中数据返回)
        public void RunQuery(string query, SqlParameter[] parameter)
        {
            SqlCommand command = CreateCommand(query, parameter);
            command.ExecuteNonQuery();
            this.Close();
        }

        #endregion

        #region   执行参数命令文本(有返回值)
        public DataSet GetViews(string query, SqlParameter[] parameter, string table)
        {
            SqlDataAdapter adapter = CreateDataAdaper(query, parameter);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, table);
            Close();
            return dataSet;
        }
        public DataSet GetViews(string query, string table)
        {
            SqlDataAdapter adapter = CreateDataAdaper(query, null);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, table);
            this.Close();
            return dataSet;
        }

        #endregion

        #region 将命令文本添加到SqlDataAdapter
        private SqlDataAdapter CreateDataAdaper(string query, SqlParameter[] parameter)
        {
            this.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            if (parameter != null)
            {
                foreach (SqlParameter param in parameter)
                    adapter.SelectCommand.Parameters.Add(param);
            }
            adapter.SelectCommand.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4,
                ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return adapter;
        }
        #endregion

        #region   将命令文本添加到SqlCommand
        private SqlCommand CreateCommand(string query, SqlParameter[] parameter)
        {
            this.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.CommandType = CommandType.Text;
            if (parameter != null)
            {
                foreach (SqlParameter param in parameter)
                    command.Parameters.Add(param);
            }
            return command;
        }
        #endregion
    }
}
