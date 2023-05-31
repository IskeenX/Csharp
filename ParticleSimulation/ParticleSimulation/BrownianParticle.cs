using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    internal class BrownianParticle : Particle
    {
        int temperature;

        public BrownianParticle(int x, int y, ConsoleColor color, int temperature) : base(x, y, color)
        {
            this.temperature = temperature;
        }

        void VelocityRandom()
        {
            velocityX = rnd.Next(-3, 4);
            velocityY = rnd.Next(-3, 4);
        }

        public override void Update(int dt, Box domain) 
        {
            VelocityRandom();
            base.Update(dt, domain); //does the main Update from Particle class
        }
    }
}