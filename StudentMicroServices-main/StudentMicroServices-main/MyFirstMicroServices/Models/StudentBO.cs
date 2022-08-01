namespace MyFirstMicroServices.Models
{
    class StudentBO
    {
        public  List<StudentModel> Students { get; set; }
        public StudentBO() => Students = StudentDAL.GetStudentBySql();
        public List<StudentModel> GetAllStudents() => Students;
        public StudentModel GetStudentByid(int id) => Students.Single(x => x.Id == id);
        public void AddStudent(StudentModel s) => Students.Add(s);
        public void EditStudentById(StudentModel s, int id) => Students[Students.FindIndex(x => x.Id == id)] = s;
        public void DeleteStudentById(int id) => Students.RemoveAt(Students.FindIndex(x => x.Id == id));
    }
}