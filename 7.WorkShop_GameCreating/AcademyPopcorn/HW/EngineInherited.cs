using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyPopcorn;


namespace HomeWork
{
    /// <summary>
    /// task 4
    /// </summary>
    public class EngineInherited : Engine
    {
        public EngineInherited(IRenderer renderer, IUserInterface userInterface,int timeToSleep)
            :base(renderer,userInterface,timeToSleep)
        { 
        }

        public void ShootPlayerRacket()
        {
        }
    }
}
