using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class GiftBlock : Block
    {        
        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body = new char[,] { { 'G' } };
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed == true)
            {                
                producedObjects.Add(new Gift(new MatrixCoords(this.topLeft.Row+1,this.topLeft.Col)));                
            }
            return producedObjects;
        }
    }
}
