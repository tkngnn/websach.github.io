using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class SqlConnectionData
    {
        //tạo chuỗi kết nối CSDL
        public static SqlConnection Connect()
        {
            string connectionString = @"Data Source=LAPTOP-G3PJNK5T; Initial Catalog=DA_QLSACH; Integrated Security=True";
            SqlConnection sqlconn = new SqlConnection(connectionString);
            return sqlconn;

        }
    }
    public class DatabaseAccess
    {
        public static string CheckDangNhapDTO(NhanVien nhanVien)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_dangnhap", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", nhanVien.UsernameNV);
            command.Parameters.AddWithValue("@pass", nhanVien.PasswordNV);

            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int u = reader.GetInt32(0);
                    user = u.ToString();
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }
}
