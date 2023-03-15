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
            Box domain = new Box(30, 20); //(width,height)
            Simulation simulation = new Simulation(domain);
            simulation.Populate(7);
            simulation.Run();
        }
    }
}