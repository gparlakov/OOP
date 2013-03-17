using System;
using System.Linq;
using AcademyPopcorn;

namespace HomeWork 
{
    class UnstopableBall : Ball
    {
         public new const string CollisionGroupString = "unstopableBall";

         public UnstopableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {

        }

         public override bool CanCollideWith(string otherCollisionGroupString)
         {
             return otherCollisionGroupString == "unpassableBlock" || otherCollisionGroupString == "racket" || otherCollisionGroupString == "indestructibleBlock";
         }

         public override void RespondToCollision(CollisionData collisionData)
         {
             if (collisionData.hitObjectsCollisionGroupStrings.Contains("unpassableBlock") || collisionData.hitObjectsCollisionGroupStrings.Contains("indestructibleBlock") ||
                 collisionData.hitObjectsCollisionGroupStrings.Contains("racket"))
             {
                 base.RespondToCollision(collisionData);
             }
         }

         public override string GetCollisionGroupString()
         {
             return UnstopableBall.CollisionGroupString;
         }
    }
}
