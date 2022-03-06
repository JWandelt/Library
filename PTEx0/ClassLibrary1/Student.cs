namespace ClassLibrary1
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        public Student(int Id, string Name, int Age)
        {
            id = Id;
            name = Name;
            age = Age;
        }
        public int Id
        { get { return id; } }

        public string Name
        { get { return name; } }

        public int Age
        { get { return age; } }
        public void addToAge(int added)
        {
            age += added;
        }

    }
}
