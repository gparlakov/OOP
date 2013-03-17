using AcademyPopcorn; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    public class ShootingRacket : Racket
    {
        public int numberRockets{ get; set; }

        public bool Shoot { get; set; }
        
        public ShootingRacket(MatrixCoords topLeft, int width) 
            : base(topLeft,width)
        {   
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return  otherCollisionGroupString == "block" ||
                    otherCollisionGroupString == Racket.CollisionGroupString ||
                    otherCollisionGroupString == "ball" ||
                    otherCollisionGroupString == "gift";
        }
        
        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("gift"))
            {
                this.numberRockets = 3;                
            }
            base.RespondToCollision(collisionData);
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            
            if (this.numberRockets > 0 && Shoot)
            {
                producedObjects.Add(new Rocket( new MatrixCoords(this.topLeft.Row-1,this.topLeft.Col + this.Width / 2)));
                this.numberRockets--;
            }            
            return producedObjects;
        }
    }
}
