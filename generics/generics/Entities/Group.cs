using generics.Interfaces;

namespace Entities
{
class Group
{
    public string Name;
    public int Id;
     public Group(int id,string name)
    {
      Id=id;
      Name=name;
    }
        public Group()
    {

    }
    private IRepository<Student,int> _students = new InMemoryRepository<Student,int>();
    public void AddStudent(Student s)
    {
        _students.Add(s.Id, s);
    }
    public void RemoveStudent(int studentId)
    {
      _students.Remove(studentId);
    }
    public IEnumerable<Student> GetAllStudents()
    {
      return _students.GetAll();
    }
    public Student FindStudent(int studentId)
    {
      return _students.Get(studentId);
    }

}
}