using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    internal class RainbowParticle : BrownianParticle
    {
        public RainbowParticle(int x, int y, ConsoleColor color, int temperature) : base(x, y, color, temperature)  
        {
        }

        public void UpdateColor()
        {
            this.Color = (ConsoleColor)(((int)this.Color + 1) % 16); //16 is max number of colors
        }
    }
}