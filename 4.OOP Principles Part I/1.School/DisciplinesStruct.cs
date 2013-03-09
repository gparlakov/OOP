using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    internal class DisciplinesStruct : BaseSchoolClass
    {
        private Disciplines discipline;
        private int numberLectures,
                    numberExercises;

        internal DisciplinesStruct(Disciplines discipline, int numLect, int numExcer)
        {
            this.Discipline = discipline;
            this.NumberExercises = numExcer;
            this.numberLectures = numLect; 
        }

        public Disciplines Discipline
        {
            get
            {
                return this.discipline;
            }
            set
            {
                this.discipline = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberLectures;
            }
            set
            {
                this.numberLectures = value;
            }
        }
        
        public int NumberExercises
        {
            get
            {
                return this.numberExercises;
            }
            set
            {
                 this.numberExercises = value;
            }
        }
    }
}
