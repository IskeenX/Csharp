using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.Model
{


    public class Bird : INotifyPropertyChanged
    {
        private double positionX;
        private double positionY;
        private double velocityY;
        private double gravity;
      
        public double PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }
        public double PositionY
        {
            get => positionY;
            set
            {
                if (positionY != value)
                {
                    positionY = value;
                    OnPropertyChanged(nameof(PositionY));
                }
            }
        }

        public double VelocityY
        {
            get => velocityY;
            private set
            {
                if (velocityY != value)
                {
                    velocityY = value;
                    OnPropertyChanged(nameof(VelocityY));
                }
            }
        }

        public double Gravity
        {
            get => gravity;
            private set
            {
                if (gravity != value)
                {
                    gravity = value;
                    OnPropertyChanged(nameof(Gravity));
                }
            }
        }

        public Bird(double initialY = 0, double initialVelocity = 0,
            double initialGravity = 0.5)
        {
            positionY = initialY;
            velocityY = initialVelocity;
            gravity = initialGravity;
            
        }

        public void Update()
        {
            VelocityY += Gravity; // Applies new gravity
            PositionY += VelocityY; // Updates position
        }

        public void Flap(double flapStrength)
        {
            VelocityY = -flapStrength; // Flap upwards - should be set from viewmodel
        }

        public bool IsOutOfBounds(double gameHeight)
        {
            return PositionY < 0 || PositionY > gameHeight;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
