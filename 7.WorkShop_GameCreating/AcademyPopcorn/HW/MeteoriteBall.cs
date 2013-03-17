using AcademyPopcorn;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork
{
    public class MeteoriteBall : Ball
    {
        private int timeToLive;

        public MeteoriteBall(MatrixCoords coords, MatrixCoords speed, int timeToLive)
            : base(coords, speed)
        {
            this.timeToLive = timeToLive;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            return new List<GameObject> { new TrailObject(this.topLeft, new char[,] { { '.' } }, this.timeToLive)};
        }

    }
}
