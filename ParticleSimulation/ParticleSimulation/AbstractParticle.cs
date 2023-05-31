using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    abstract class AbstractParticle
    {
        protected int positionX;
        protected int positionY;

        abstract public void Update(int dt, Box domain);
    }
}