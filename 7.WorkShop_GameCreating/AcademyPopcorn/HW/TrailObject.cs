using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class TrailObject : GameObject    
    {
        public int TimeToLive { get; protected set; }
        
        public TrailObject (MatrixCoords topLeft, char[,] body,int timeToLive)
            :base(topLeft,body)
        {
            this.TimeToLive = timeToLive;
        }

        public override void Update()
        {
            if (this.TimeToLive > 0)
            {
                this.TimeToLive--;                
            }
            else
            {
                this.IsDestroyed = true;
            }
        }
    }
}
