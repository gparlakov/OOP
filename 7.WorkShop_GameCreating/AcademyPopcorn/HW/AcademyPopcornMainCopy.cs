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

            for (int i = startCol; i < endCol; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);

            //1.Task
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
            Racket secondRacket = new Racket(new MatrixCoords(WorldRows - 2, (WorldCols - 1) / 2), 3);
            engine.AddObject(secondRacket);

            //task 5 Trail Object
            //TrailObject trail = new TrailObject(new MatrixCoords(15,6),new char[,] {{'.'}}, 4);
            //engine.AddObject(trail);

            //task 6 and 7 Meteorite Ball
            MeteoriteBall meteoriteBall = new MeteoriteBall(theBall.TopLeft, theBall.Speed, 3);
            engine.AddObject(meteoriteBall);
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
