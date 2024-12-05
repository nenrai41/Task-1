using GarifullinRE;
try
{
    Student student1 = new Student("Иван", "Иванов", "Иванович", "М1О-103БВ-24", "123456", Course.First);
    Student student2 = new Student("Петр", "Петров", "Петрович", "М2О-211БВ-23", "654321", Course.Second);

    Console.WriteLine(student1);
    Console.WriteLine();
    Console.WriteLine(student2);

    Console.WriteLine();
    Console.WriteLine($"Один и тот же студент? {student1.Equals(student2)}");

    Console.WriteLine();
    HashSet<Student> students = new HashSet<Student>();
    students.Add(student1);
    students.Add(student2);

    Student student1Dublicate = new Student("Иван", "Иванов", "Иванович", "М1О-103БВ-24", "123456", Course.First);
    Console.WriteLine($"Добавлен ли дубликат студента? {students.Add(student1Dublicate)}");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}
