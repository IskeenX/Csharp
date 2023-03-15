using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSimulation
{
    internal class Simulation
    {
        static Random rnd = new Random();
        Particle[] particles;
        Box domain;

        public Simulation(Box domain)
        {
            this.domain = domain;
        }

        public void Populate(int size) //number of particles and their settings
        {
            particles = new Particle[size];
            for (int i = 0; i < particles.Length; i++)
            {
                int x = rnd.Next(1, domain.Width);
                int y = rnd.Next(1, domain.Height);
                ConsoleColor color = (ConsoleColor)rnd.Next(Enum.GetNames(typeof(ConsoleColor)).Length); //random colors except Black
                particles[i] = new Particle (x, y, color);
            }
        }

        public void Rendering() //clears and draws everything again
        {
            Console.Clear();
            domain.Show();
            foreach (Particle p in particles)
            {
                p.Show();
            }
        }

        public void UpdateParticles(int dt) //particle positions
        {
            foreach (Particle p in particles)
            {
                p.Update(dt, this.domain);
            }
        }
        
        public void Run()
        {
            while (true)
            {
                Rendering();
                UpdateParticles(1); //Speed of particles
                System.Threading.Thread.Sleep(15); //Repeating time
            }
        }
    }
}
