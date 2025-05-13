using generics.Interfaces;

namespace Entities
{
class Faculty
{
    public int Id;
    public string Name;
    public Faculty(int id, string name)
    {
      Id=id;
      Name=name;
    }
    private IRepository<Group,int> _groups = new InMemoryRepository<Group,int>();
    public void AddGroup(Group g)
    {
       _groups.Add(g.Id, g);
    }
    public void RemoveGroup(int Id)
    {
       _groups.Remove(Id);
    }
    public IEnumerable<Group> GetAllGroups()
    {
      return _groups.GetAll();
    }
    public  Group GetGroup(int Id)
    {
      return _groups.Get(Id);
    }
    public void AddStudentToGroup(int groupId, Student s)
    {
       var group = GetGroup(groupId);
        group.AddStudent(s);

    }
    public void RemoveStudentFromGroup(int groupId, int studentId)
    {
        var group = _groups.Get(groupId);
        group.RemoveStudent(studentId);

    }
    public IEnumerable<Student> GetAllStudentsInGroup(int groupId)
    {
        var group = _groups.Get(groupId);
        return group.GetAllStudents();

    }
    public  Student FindStudentInGroup(int groupId, int studentId)
    {
        var group = _groups.Get(groupId);
        return group.FindStudent(studentId);

    }

}
}