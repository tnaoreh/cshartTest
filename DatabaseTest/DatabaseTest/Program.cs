using System;
using System.Data.SqlClient;

namespace DatabaseTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sql 연결정보(서버:127.0.0.1, 포트:3535, 아이디:sa, 비밀번호 : password, db : member)
            string connectionString = "server = 127.0.0.1,1433; uid = heroant; pwd = king2090; database = mcm;";
            // Sql 새연결정보 생성
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;
            sqlComm.CommandText = "insert into users (user_idxx, user_name, inst_time) values ('841004','MUN',getdate())";
            //sqlComm.CommandText = "update tbl_member set addr=@param3 where id=@param1 and name=@param2";
            //sqlComm.CommandText = "delete tbl_member where id=@param1 and name=@param2 and addr=@param3";
            //sqlComm.Parameters.AddWithValue("@param1", "'870403'");
            //sqlComm.Parameters.AddWithValue("@param2", "'risa'");
            //sqlComm.Parameters.AddWithValue("@param3", "getdate()");
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            Console.WriteLine("Hello World! it's git test");
        }
    }
}
