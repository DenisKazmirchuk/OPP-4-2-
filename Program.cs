using System;

class Faculty
{
    public class Department
    {
        private string departmentName;
        private int teacherCount;
        private string[] subjects;

        public void SetDepartmentName(string name)
        {
            departmentName = name;
        }

        public void SetTeacherCount(int count)
        {
            teacherCount = count;
        }

        public string this[int index]
        {
            get => subjects[index];
            set
            {
                if (subjects == null)
                {
                    subjects = new string[5]; // наприклад, до 5 дисциплін
                }
                subjects[index] = value;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Кафедра: {departmentName}, кількість викладачів: {teacherCount}");
        }
    }

    private Department department1 = new Department();
    private Department department2 = new Department();

    public void SetDepartmentsInfo()
    {
        department1.SetDepartmentName("Комп'ютерних наук та ІПЗ");
        department1.SetTeacherCount(10);
        department1[0] = "Програмування";
        department1[1] = "Алгоритми";

        department2.SetDepartmentName("Вищої математики");
        department2.SetTeacherCount(5);
        department2[0] = "Математичний аналіз";
        department2[1] = "Лінійна алгебра";
    }

    public void DisplayFacultyInfo()
    {
        Console.WriteLine("Факультет: Комп'ютерних наук та ІПЗ");
        department1.DisplayInfo();
        department2.DisplayInfo();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Faculty faculty = new Faculty();
        faculty.SetDepartmentsInfo();
        faculty.DisplayFacultyInfo();
        Console.ReadKey();
    }
}
