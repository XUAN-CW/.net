### Student.cs

```c#
using System.Data.Entity;
namespace TestEF
{

  public class Student
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
  }

  public class StudentDBContext : DbContext
  {
  	public DbSet<Student> Students { get; set; }
  } 

}
```

### Program.cs

```c#
namespace TestEF
{
    class Program
    {
        static StudentDBContext db = new StudentDBContext();

        static void Main(string[] args)
        {
            Student student = new Student() { ID = 1, Name = "张飞", Age = 20 };
            db.Students.Add(student);
            db.SaveChanges();
        }
        
    }
}

```



## Entity Framework增删改操作

### 添加操作：

```c#
Student student = new Student() {  ID = 1, Name = "张飞",  Age = 20  };
db.Students.Add(student);
db.SaveChanges();
```

### 删除操作：

```c#
Student student = db.Students.Find(1);
db.Students.Remove(student);
db.SaveChanges();
```

### 修改操作：

```c#
Student student = db.Students.Find(1);
student.Name = "关羽";
student.Age = 30;
db.SaveChanges();
```

