using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.Model
{
    public class PipeGenerator
    {
        private readonly List<TopPipe> topPipes;
        private readonly List<BottomPipe> bottomPipes;
        private readonly Random random;

        public PipeGenerator()
        {
            topPipes = new List<TopPipe>();
            bottomPipes = new List<BottomPipe>();
            random = new Random();
        }

        public IReadOnlyList<TopPipe> TopPipes => topPipes;
        public IReadOnlyList<BottomPipe> BottomPipes => bottomPipes;

        public void Update()
        {
            foreach (var pipe in topPipes)
            {
                pipe.Move();
            }

            foreach (var pipe in bottomPipes)
            {
                pipe.Move();
            }

            // Remove pipes that are out of screen
            topPipes.RemoveAll(pipe => pipe.IsOutOfScreen(Constants.ScreenWidth));
            bottomPipes.RemoveAll(pipe => pipe.IsOutOfScreen(Constants.ScreenWidth));
        }

        public void GenerateRandomPipe(double gapSize)
        {
            double gapPositionY = random.NextDouble() * (Constants.ScreenHeight - gapSize);
            var topPipe = new TopPipe(Constants.ScreenWidth, gapPositionY, gapSize, Constants.PipeWidth, Constants.PipeSpeed);
            var bottomPipe = new BottomPipe(Constants.ScreenWidth, gapPositionY + gapSize, Constants.ScreenHeight - gapPositionY - gapSize, Constants.PipeWidth, Constants.PipeSpeed);
            topPipes.Add(topPipe);
            bottomPipes.Add(bottomPipe);
        }


    }
}
