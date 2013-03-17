using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassableBlock";
        public int Lifes { get; set; }

        public UnpassableBlock(MatrixCoords topLeft, int lifes)
            : base(topLeft)
        {
            this.body = new char[,] { { '*' } };
            this.Lifes = lifes;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "unstopableBall";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains("unstopableBall"))
            {
                if (this.Lifes > 0)
                {
                    this.Lifes--;
                    this.body[0, 0]--;
                    Console.WriteLine("hit");
                }
                else
                {
                    this.IsDestroyed = true;
                }
            }
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
