﻿using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Gift : MovingObject
    {
        //public static const Oth;

        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,]{{'G'}},new MatrixCoords(1,0))
        {           
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
