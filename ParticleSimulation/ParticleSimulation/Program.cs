using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    class Program
    {
        static void Main()
        {
            Box domain = new Box(50, 20); //(width,height)
            Simulation simulation = new Simulation(domain);
            simulation.Populate(4);

            Particle p = new BrownianParticle(1, 1, ConsoleColor.Green, 100);
            RainbowParticle h = new RainbowParticle(1, 1, ConsoleColor.Red, 100);

            simulation.Add(p, 1); //changes one particle to (random-velocity particle)
            simulation.Add(h, 2); //changes color of (random-velocity particle)
            simulation.Run();
        }
    }
}