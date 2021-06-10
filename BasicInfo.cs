using OrderSystem;
using System.Data;
using System.Data.SqlClient;

namespace BasicInfo
{
    #region MenuInfo类主属性区
    public class Menu
    {
        private DataBase dataBase = new DataBase();
        public string Number { get; set; } = "";
        public string Name { get; set; } = "";
        public string Specification { get; set; } = "";
        public string Type { get; set; } = "";
        public float Price { get; set; } = 0;
        public string Description { get; set; } = "";
        public string TABLE = "menus";
        public DataSet ShowMenu()
        {
            return dataBase.GetViews("select * from " + TABLE + " order by number", TABLE);
        }
        #region 保存菜品信息
        public void AddMenu()
        {
            SqlParameter[] param = {
                                        dataBase.GetSqlParameter("@number", SqlDbType.Int, 4, Number),
                                        dataBase.GetSqlParameter("@name", SqlDbType.VarChar, 20, Name),
                                        dataBase.GetSqlParameter("@specification", SqlDbType.VarChar, 10, Specification),
                                        dataBase.GetSqlParameter("@type", SqlDbType.VarChar, 10, Type),
                                        dataBase.GetSqlParameter("@price", SqlDbType.Float, 10, Price),
                                        dataBase.GetSqlParameter("@description",SqlDbType.VarChar,8000,Description)
            };
            dataBase.RunQuery("INSERT INTO " + TABLE + " (number,name,specification,type,price,description) VALUES (@number,@name,@specification,@type,@price,@description)", param);
        }
        #endregion
        #region 修改菜品信息
        public void UpdateMenu()
        {
            SqlParameter[] param = {
                                        dataBase.GetSqlParameter("@number", SqlDbType.Int, 4, Number),
                                        dataBase.GetSqlParameter("@name", SqlDbType.VarChar, 20, Name),
                                        dataBase.GetSqlParameter("@specification", SqlDbType.VarChar, 10, Specification),
                                        dataBase.GetSqlParameter("@type", SqlDbType.VarChar, 10, Type),
                                        dataBase.GetSqlParameter("@price", SqlDbType.Float, 10, Price),
                                        dataBase.GetSqlParameter("@description", SqlDbType.VarChar,8000, Description),
            };
            dataBase.RunQuery("update " + TABLE + " set name=@name,specification=@specification,type=@type,price=@price,description=@description where number=@number", param);
        }
        #endregion
        #region 查找菜品信息
        public DataSet SearchByType()
        {
            SqlParameter[] param = {
                                        dataBase.GetSqlParameter("@type",  SqlDbType.VarChar, 10, Type),
            };
            return dataBase.GetViews("select * from " + TABLE + " where type = @type", param, TABLE);
        }
        #endregion
        #region 删除菜品信息
        public void Delete()
        {
            SqlParameter[] param = {
                                        dataBase.GetSqlParameter("@number",  SqlDbType.Int, 4, Number),
            };
            dataBase.RunQuery("delete from " + TABLE + " where number=@number", param);
        }
        #endregion

    }
    #endregion

    #region 顾客基本信息
    public class Customer
    {
        private DataBase data = new DataBase();
        public string AccountNumber { get; set; } = "";
        public string Name { get; set; } = "";
        public string Password { get; set; } = "";
        public int State { get; set; } = 0;
        private readonly string TABLE = "customers";
        #region 顾客注册
        public void Register()
        {
            SqlParameter[] param = {
                data.GetSqlParameter("@accountNumber",SqlDbType.VarChar, 11, AccountNumber),
                data.GetSqlParameter("@name",SqlDbType.VarChar, 20, Name),
                data.GetSqlParameter("@password",SqlDbType.VarChar, 10, Password),
                data.GetSqlParameter("@state",SqlDbType.Int, 1, State),
            };
            data.RunQuery("INSERT INTO " + TABLE + " (account_number, name, password, state) VALUES (@accountNumber,@name,@password,@state)", param);
        }
        #endregion

        #region 顾客登陆
        public DataSet Login()
        {
            SqlParameter[] parameters = {
                                        data.GetSqlParameter("@accountNumber",  SqlDbType.VarChar, 11, AccountNumber),
                                        data.GetSqlParameter("@password",  SqlDbType.VarChar, 8, Password),
            };
            return data.GetViews("select * from " + TABLE + " where account_number=@accountNumber ", parameters, TABLE);
        }
        #endregion

        #region 修改顾客信息
        public void ChangeInfo()
        {
            SqlParameter[] param = {
                                      data.GetSqlParameter("@accountNumber", SqlDbType.VarChar, 10, AccountNumber),
                                      data.GetSqlParameter("@name",SqlDbType.VarChar, 20, Name),
                                      data.GetSqlParameter("@password",  SqlDbType.VarChar, 10, Password),
                                      data.GetSqlParameter("@state",  SqlDbType.Int, 1, State),
            };
            data.RunQuery("update " + TABLE + " set name=@name,password=@password,state=@state where account_number=@accountNumber", param);
        }
        #endregion

    }
    #endregion

    #region Order类主属性区
    public class Order
    {
        private string TABLE = "orders";
        private DataBase data = new DataBase();
        public int SerialNumber { get; set; } = 0;
        public string Customer { get; set; } = "";
        public string Details { get; set; } = "";
        public float TotalCost { get; set; } = 0;
        public string Time { get; set; } = "";
        #region 新增订单
        public void NewOrder()
        {
            SqlParameter[] param = {
                                        data.GetSqlParameter("@serial_number",SqlDbType.VarChar, 10, SerialNumber),
                                        data.GetSqlParameter("@customer",SqlDbType.VarChar, 20, Customer),
                                        data.GetSqlParameter("@details",SqlDbType.NVarChar, 100, Details),
                                        data.GetSqlParameter("@total_cost",SqlDbType.Float, 10, TotalCost),
                                        data.GetSqlParameter("@time",SqlDbType.Text, 20, Time),
            };
            data.RunQuery("INSERT INTO " + TABLE + " (serial_number, customer, details,total_cost, time) VALUES (@serial_number,@customer,@details,@total_cost,@time)", param);
        }
        #endregion
        #region 更新订单信息
        public void Update()
        {
            SqlParameter[] param = {
                                       data.GetSqlParameter("@serial_number", SqlDbType.VarChar, 10, SerialNumber),
                                        data.GetSqlParameter("@customer",SqlDbType.VarChar, 20, Customer),
                                        data.GetSqlParameter("@details",  SqlDbType.NVarChar, 100, Details),
                                        data.GetSqlParameter("@total_cost",  SqlDbType.Float, 10, TotalCost),
            };
            data.RunQuery("update " + TABLE + " set customer=@customer,details=@details,total_cost=@total_cost where serial_number=@serial_number", param);
        }
        #endregion
        #region 查找订单信息
        public DataSet SearchOrders(string accordance)
        {
            SqlParameter[] param = new SqlParameter[1];
            switch (accordance)
            {
                //用于检测该顾客有无未完成订单
                case "This Unsettled":
                    param[0] = data.GetSqlParameter("@customer", SqlDbType.VarChar, 11, Customer);
                    return data.GetViews("select * from " + TABLE + " where customer=@customer and state is null", param, TABLE);
                //用于检测某桌是否已有顾客用餐
                case "Repeat SerialNumber":
                    param[0] = data.GetSqlParameter("@serial_number", SqlDbType.VarChar, 11, SerialNumber);
                    return data.GetViews("select * from " + TABLE + " where serial_number=@serial_number and state is null", param, TABLE);
                //通过桌号查找订单
                case "SerialNumber":
                    param[0] = data.GetSqlParameter("@serial_number", SqlDbType.VarChar, 11, SerialNumber);
                    return data.GetViews("select * from " + TABLE + " where serial_number=@serial_number", param, TABLE);
                //查找所有订单
                case "All":
                    return data.GetViews("select * from " + TABLE + " ORDER BY serial_number", TABLE);
                //查找已结账订单
                case "Settled":
                    return data.GetViews("select * from " + TABLE + " where state='已结账' ORDER BY serial_number ", TABLE);
                //查找未结账订单
                case "Unsettled":
                    return data.GetViews("select * from " + TABLE + " where state is null ORDER BY serial_number ", TABLE);
                //通过顾客查找订单
                case "Customer":
                    param[0] = data.GetSqlParameter("@customer", SqlDbType.VarChar, 11, Customer);
                    return data.GetViews("select * from " + TABLE + " where customer=@customer", param, TABLE);
                default:
                    return null;
            }
        }
        #endregion
        #region 结账
        public void Settle()
        {
            SqlParameter[] param = {
                                       data.GetSqlParameter("@serial_number", SqlDbType.VarChar, 10, SerialNumber),
            };
            data.RunQuery("update " + TABLE + " set state='已结账' where serial_number=@serial_number", param);

        }
        #endregion
    }
    #endregion
}