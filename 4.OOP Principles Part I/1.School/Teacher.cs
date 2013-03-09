using System.Collections.Generic;
namespace School
{
    internal class Teacher : Human
    {
        private ICollection<Disciplines> disciplines;

        internal Teacher(string name, string lName, int years)
            : base(name, lName, years)
        {
            this.disciplines = new List<Disciplines>();
        }

        internal Teacher(string name, string lName, int years, ICollection<Disciplines> disciplines)
            : this(name, lName, years)
        {
            this.Disciplines = disciplines;
        }

        internal ICollection<Disciplines> Disciplines {
            get
            {
                return this.disciplines;                
            }
            set
            {
                foreach (var discipline in disciplines)
                {
                    this.disciplines.Add(discipline);
                }
            }
        }

        internal void AddDiscipline(Disciplines discipline)
        {
            this.disciplines.Add(discipline);
        }

        internal void RemoveDiscipline(Disciplines discipline)
        {
            this.disciplines.Remove(discipline);
        }

    }
}
