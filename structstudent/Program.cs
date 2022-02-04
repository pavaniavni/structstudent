namespace StructClass
{
    
    public struct Student
    {
        public string Name;
        public string Class;
        public string Gender;
        public void GetData()
        {
            Console.WriteLine("Enter student name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class of the student: ");
            Class = Console.ReadLine();
            Console.WriteLine("Enter the gender of the student");
            Gender = Console.ReadLine();

        }
        public void ShowData()
        {
            Console.WriteLine("The Name of student is " + Name);
            Console.WriteLine("The class of student is " + Class);
            Console.WriteLine("The gender of student is " + Gender);
        }

    }

    class Structvsenum
    {
        
        
        public static void Main()
        {
            Student student=new Student();
            student.GetData();
            student.ShowData();
            

    
        }
    }
}
