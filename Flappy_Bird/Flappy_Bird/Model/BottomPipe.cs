using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.Model
{
    public class BottomPipe : INotifyPropertyChanged
    {
        private double positionX;
        private double gapPositionY;
        private double gapSize;
        private double width;
        private double speed;

        public double PositionX
        {
            get => positionX;
            private set
            {
                if (positionX != value)
                {
                    positionX = value;
                    OnPropertyChanged(nameof(PositionX));
                }
            }
        }

        public double GapPositionY
        {
            get => gapPositionY;
            private set
            {
                if (gapPositionY != value)
                {
                    gapPositionY = value;
                    OnPropertyChanged(nameof(GapPositionY));
                }
            }
        }

        public double GapSize
        {
            get => gapSize;
            private set
            {
                if (gapSize != value)
                {
                    gapSize = value;
                    OnPropertyChanged(nameof(GapSize));
                }
            }
        }

        public double Width
        {
            get => width;
            private set
            {
                if (width != value)
                {
                    width = value;
                    OnPropertyChanged(nameof(Width));
                }
            }
        }

        public double Speed
        {
            get => speed;
            private set
            {
                if (speed != value)
                {
                    speed = value;
                    OnPropertyChanged(nameof(Speed));
                }
            }
        }

        public BottomPipe(double positionX, double gapPositionY, double gapSize, double width, double speed)
        {
            this.positionX = positionX;
            this.gapPositionY = gapPositionY;
            this.gapSize = gapSize;
            this.width = width;
            this.speed = speed;
        }

        public void Move()
        {
            PositionX -= Speed; // Move the pipe to the left
        }

        public bool IsOutOfScreen(double screenWidth)
        {
            return PositionX < -Width; // Check if the pipe is out of the screen
        }

        public bool IsCollision(double birdX, double birdY, double birdWidth, double birdHeight)
        {
            // Check collision with the pipe's bounding box
            if (birdX + birdWidth < PositionX || birdX > PositionX + Width)
                return false;

            // Check collision with the bottom part of the pipe
            return birdY + birdHeight > GapPositionY + GapSize;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
