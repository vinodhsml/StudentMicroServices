
using System.Data.SqlClient;
namespace MyFirstMicroServices.Models
{
    public static class StudentDAL
    {
        static SqlConnection cn;
        static SqlConnection ConnectToSql()
        {
            cn = new SqlConnection("server=DESKTOP-DM30GHJ;user id=sa;password=welcome;database=StudentDB");
            cn.Open();
            return cn;
        }
        public static List<StudentModel> GetStudentBySql()
        {
            List<StudentModel> students = new List<StudentModel>();
            SqlCommand cmd = new SqlCommand("Select * From tblSTudents", ConnectToSql());
            SqlDataReader dr = cmd.ExecuteReader();
            StudentModel s;
            while (dr.Read())
            {
                s = new StudentModel();
                s.Id = Convert.ToInt32(dr[0]);
                s.SName = dr[1].ToString();
                s.Course = dr[2].ToString();
                s.Fee = Convert.ToInt32(dr[3]);
                students.Add(s);
            }
            return students;
        }
    }
}