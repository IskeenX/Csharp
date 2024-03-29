﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    internal class Particle : AbstractParticle, IVisualizable
    {
        static protected Random rnd = new Random();

        public double velocityX { get; protected set; }
        public double velocityY { get; protected set; }
        public ConsoleColor Color { get; set; }

        public Particle(int posX, int posY, double velX, double velY, ConsoleColor color)
        {
            this.positionX = posX;
            this.positionY = posY;
            this.velocityX = velX;
            this.velocityY = velY;
            this.Color = color;
        }

        public Particle(int posX, int posY, ConsoleColor color) : this(posX, posY, 0, 0, color)
        {
            this.velocityX = rnd.Next(-3, 3);
            this.velocityY = rnd.Next(-3, 3);
        } //if velocity is zero

        public override void Update(int dt, Box domain) //positioning of particles
        {
            int targetX = this.positionX + (int)Math.Round(dt * velocityX);
            int targetY = this.positionY + (int)Math.Round(dt * velocityY);
            if (targetX <= 0 || targetX >= domain.Width) velocityX = -velocityX;
            else if (targetY <= 0 || targetY >= domain.Height) velocityY = -velocityY;
            else
            {
                this.positionX = targetX;
                this.positionY = targetY;
            }
        }

        public void Show() //displaying particles
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(positionX, positionY);
            Console.ForegroundColor = Color;
            Console.Write('O');
        }
    }
}