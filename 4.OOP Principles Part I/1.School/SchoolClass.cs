using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace School
{
    internal class SchoolClass : BaseSchoolClass
    {
        private ICollection<Student> students;
        private ICollection<DisciplinesStruct> disciplines;
        private string className;
        private ICollection<Teacher> teachers;

        #region Constructors
        /// <summary>
        /// Creates an instance of class SchoolClass with a name. Students and disciplines can be added later
        /// </summary>
        /// <param name="className"></param>
        internal SchoolClass(string className)
        {
            this.className = className;
            this.students = new List<Student>();
            this.disciplines = new List<DisciplinesStruct>();
            this.teachers = new List<Teacher>();
        }

        /// <summary>
        /// Creates an instance of class SchoolClass with a name, collection of students and collection of disciplines they study
        /// </summary>
        /// <param name="className"></param>
        /// <param name="students"></param>
        /// <param name="disciplines"></param>
        internal SchoolClass(string className, ICollection<Student> students, ICollection<DisciplinesStruct> disciplines)
            : this(className)
        {
            this.Students = students;
            this.Disciplines = disciplines;            
        }

        internal SchoolClass(string className, ICollection<Student> students, ICollection<DisciplinesStruct> disciplines,ICollection<Teacher> teachers)
            : this(className,students,disciplines)
        {
            this.Teachers = teachers;
        }
        #endregion

        #region Properties
        internal ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                foreach (var student in value)
                {
                    this.students.Add(student);
                }
            }
        }

        internal ICollection<DisciplinesStruct> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                foreach (var discipline in value)
                {
                    this.disciplines.Add(discipline);
                }
            }
        }

        internal ICollection<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            set
            {
                foreach (var teacher in value)
                {
                    this.teachers.Add(teacher);
                }                
            }
        }
        #endregion
         
        #region Methods
        //the add/remove stundent/discipline/teacher section

        internal void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        internal void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }

        internal void AddDiscipline(DisciplinesStruct discipline)
        {
            this.disciplines.Add(discipline);
        }

        internal void RemoveDiscipline(Disciplines discipline)
        {
            DisciplinesStruct temp = null;
            foreach (var dicipline in this.Disciplines)
            {
                if (dicipline.Discipline == discipline)
                {
                    temp = dicipline;
                }
            }
            if (temp != null)
            {
                this.Disciplines.Remove(temp);
            }
        }

        internal void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        internal void RemoveTeacher(Teacher teacher)
        {
            this.teachers.Remove(teacher);
        }

        public override string ToString()
        {
            String teachers, students, disciplines;
            ICollection<Disciplines> tempClassDisciplines = new List<Disciplines>();
            foreach (var discipline in this.Disciplines)
            {
                tempClassDisciplines.Add(discipline.Discipline);
            }

            teachers = ToStringTemp<Teacher>(this.Teachers);
            students = ToStringTemp<Student>(this.Students);
            disciplines = ToStringTemp<Disciplines>(tempClassDisciplines);
           

            return string.Format("Class name: {0}\nTeacher(s): {1}\nStudents:{2}\nDisciplines this class studies: {3}",
                this.className,teachers,students,disciplines);
        }

        private string ToStringTemp<T>(ICollection<T> collection) 
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\n");
            foreach (var item in collection)
            {
                builder.Append(item + "\n");
            }
            builder = RemoveLastComma(builder);
            return builder.ToString();
        }

        private StringBuilder RemoveLastComma(StringBuilder toBeRemoved)
        {
            return toBeRemoved.Remove(toBeRemoved.Length - 1, 1);
        }


        #endregion

    }
}
