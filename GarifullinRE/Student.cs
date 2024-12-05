using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GarifullinRE
{
    public class Student : IEquatable<Student>
    {
        public Student(string firstName, string surname, string patronymic,string studyGroup, string recordBooksID, Course course)
        {
            FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName), "Имя не может быть null.");
            Surname = surname ?? throw new ArgumentNullException(nameof(surname), "Фамилия не может быть null.");
            Patronymic = patronymic ?? throw new ArgumentNullException(nameof(patronymic), "Отчество не может быть null.");
            StudyGroup = studyGroup ?? throw new ArgumentNullException(nameof(studyGroup), "Номер учебной группы не может быть null.");
            RecordBooksID = recordBooksID ?? throw new ArgumentNullException(nameof(recordBooksID), "Номер зачетной книжки не может быть null.");

        }
        public override string ToString()
        {
            return $"ФИО студента: {Surname} {FirstName} {Patronymic} \nКурс: {Course} \nНомер учебной группы: {StudyGroup} \nНомер зачетной книжки: {RecordBooksID}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Student otherStudent)
            {
                return Equals(otherStudent);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Surname, FirstName, Patronymic, StudyGroup, RecordBooksID, Course);
        }

        public bool Equals(Student otherStudent)
        {
            if (otherStudent == null) return false;
            return FirstName == otherStudent.FirstName &&
                   Surname == otherStudent.Surname &&
                   Patronymic == otherStudent.Patronymic &&
                   StudyGroup == otherStudent.StudyGroup &&
                   RecordBooksID == otherStudent.RecordBooksID &&
                   Course == otherStudent.Course;
        }

        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string StudyGroup { get; set; }
        public string RecordBooksID { get; set; }

        public Course Course;

    }
    public enum Course
    {
        First,
        Second,
        Third,
        Fourth
       
    }
}
