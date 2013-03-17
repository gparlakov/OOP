using AcademyPopcorn;
using System;
using System.Collections.Generic;

namespace HomeWork
{
    class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "unstopableBlock";

        public ExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = new char[,] { { '+' } };
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "ball" || otherCollisionGroupString == "meteoriteBall" || otherCollisionGroupString == "unstopableBall";//|| otherCollisionGroupString == "object";
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }
                       
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();

            if (this.IsDestroyed == true)
            {                
                for (int y = -1; y < 2; y++)
                {
                    for (int x = -1; x < 2; x++)
                    {
                        producedObjects.Add(new Shrapnel(new MatrixCoords(this.topLeft.Row, this.topLeft.Col), new MatrixCoords(y,x)));
                    }
                }
            }
            return producedObjects;
        }
    }
}
