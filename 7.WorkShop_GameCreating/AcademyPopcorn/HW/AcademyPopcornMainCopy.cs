using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyPopcorn;

namespace HomeWork
{
    class AcademyPopcornMainCopy
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 0;
            int endCol = WorldCols - 2;

            for (int i = startCol; i <= endCol; i++)
            {
                
                Block currBlock = new Block(new MatrixCoords(startRow, i));
                engine.AddObject(currBlock);

                //clear the exploding block's positions
                if (i != 6 && i !=15 )
                {
                   Block currBlock2 = new Block(new MatrixCoords(startRow+1, i));
                   engine.AddObject(currBlock2); 
                }
                 

                //task 8 and 9 - unstopableBall and unpassableBlock
                UnpassableBlock currUnstBlock = new UnpassableBlock(new MatrixCoords(WorldRows / 2 + 1, i), 1);                
                engine.AddObject(currUnstBlock);
            }
             
            //old ball
            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));                      

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //1.Task - walls
            for (int i = 0; i < WorldRows; i++)
            {
                Block nextLeft = new IndestructibleBlock(new MatrixCoords(i, 0));
                Block nextRight = new IndestructibleBlock(new MatrixCoords(i, WorldCols-1));

                engine.AddObject(nextLeft);
                engine.AddObject(nextRight);                
            }

            for (int i = 0; i < WorldCols; i++)
            {
                Block nextTop = new IndestructibleBlock(new MatrixCoords(0, i));
                engine.AddObject(nextTop);
            }

            //task 3 Add second racket
            Racket secondRacket = new Racket(new MatrixCoords(WorldRows - 2, (WorldCols - 1) / 2), 10);
            engine.AddObject(secondRacket);

            //task 5 Trail Object
            //TrailObject trail = new TrailObject(new MatrixCoords(15,6),new char[,] {{'.'}}, 4);
            //engine.AddObject(trail);

            //task 6 and 7 Meteorite Ball
            //MeteoriteBall meteoriteBall = new MeteoriteBall(theBall.TopLeft, theBall.Speed, 3);
            //engine.AddObject(meteoriteBall);

            //task 8 and 9 - unstopableBall and unpassableBlock
            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));
            engine.AddObject(theBall);

            //task 10 - exploding block
            ExplodingBlock explodingBlock = new ExplodingBlock(new MatrixCoords(4,15));            
            engine.AddObject(explodingBlock);
            

            //task 11 and 12 Gift Block and Gift moving object
            GiftBlock giftBlock = new GiftBlock(new MatrixCoords(4, 6));
            engine.AddObject(giftBlock);
        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            Engine gameEngineOld = new Engine(renderer, keyboard);
            
            //task 2 with sleep time
            Engine gameEngine = new Engine(renderer, keyboard, 100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
