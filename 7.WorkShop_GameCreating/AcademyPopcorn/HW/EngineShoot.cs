using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyPopcorn;


namespace HomeWork
{
    /// <summary>
    /// task 4
    /// </summary>
    public class EngineShoot : Engine
    {
        ShootingRacket playerRacket;        

        public EngineShoot(IRenderer renderer, IUserInterface userInterface, int timeToSleep)
            : base(renderer, userInterface, timeToSleep)
        {            
        }

        public override void AddObject(GameObject obj)
        {
            if (obj is ShootingRacket)
            {
                this.playerRacket = obj as ShootingRacket;
                base.AddObject(obj);
            }
            else
            {
                base.AddObject(obj);
            }
            
        }

        public void ShootPlayerRacket()
        {            
            playerRacket.Shoot = true;
            playerRacket.numberRockets = 3;
        }

        //private void AddRacket(GameObject obj)
        //{
        //    //TODO: we should remove the previous racket from this.allObjects
        //    //task 3:remove from list of objects to render
        //    RemoveOldRacket();

        //    this.playerRacket = obj as ShootingRacket;
        //    this.AddStaticObject(obj);
        //}

        //private void AddStaticObject(GameObject obj)
        //{
        //    this.staticObjects.Add(obj);
        //    this.allObjects.Add(obj);
        //}

        //private void RemoveOldRacket()
        //{
        //    //task 3:remove from list of objects to render
        //    RemoveRacketFrom(this.allObjects);

        //    //remove from static objects so the ball doesen't bounce from the air
        //    RemoveRacketFrom(this.staticObjects);
        //}

        //private void RemoveRacketFrom(List<GameObject> list)
        //{
        //    //take list from whence to remove racket
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        if (list[i].GetCollisionGroupString() == "racket")
        //        {
        //            list.RemoveAt(i);
        //            //this.playerRacket.IsDestroyed = true;
        //        }
        //    }
        //}
    }
}
