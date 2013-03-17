using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Rocket : MovingObject
    {
        public Rocket(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { '^' } }, new MatrixCoords(-1, 0))
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block"
                || otherCollisionGroupString == "indestructibleClock"
                || otherCollisionGroupString == "giftBlock"
                || otherCollisionGroupString == "unpassableBlock";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObj = new List<GameObject>();
            if (this.IsDestroyed == true)
            {
                producedObj.Add(new Shrapnel(new MatrixCoords(this.topLeft.Row - 1 ,this.topLeft.Col),
                    new MatrixCoords(-1,0) ));
            }
            return producedObj;
        }
    }
}
