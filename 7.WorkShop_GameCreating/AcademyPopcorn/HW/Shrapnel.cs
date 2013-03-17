using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Shrapnel : MovingObject
    {
        public new const string CollisionGroupString = "ball";
        private int life = 1;

        public Shrapnel(MatrixCoords topLeft,MatrixCoords speed)
            : base(topLeft,new char[,]{{'.'}},speed)
        {   
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }

        public override void Update()
        {
            if (this.life > 0)
            {
                this.life--;
            }
            else
            {
                this.IsDestroyed = true;
            }

        }
    }
}
