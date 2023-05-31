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
        Box domain;
        AbstractParticle[] particles;
        IVisualizable[] visualizables;

        public Simulation(Box domain) //?
        {
            this.domain = domain;
        }   

        public void Populate(int size) //number of particles
        {
            visualizables = new IVisualizable[size + 1];
            particles = new AbstractParticle[size];
            for (int i = 0; i < particles.Length; i++)
            {
                int x = rnd.Next(1, domain.Width - 1);
                int y = rnd.Next(1, domain.Height - 1);
                ConsoleColor color = (ConsoleColor)rnd.Next(1, Enum.GetNames(typeof(ConsoleColor)).Length); //random colors except Black
                AbstractParticle p = new Particle(x, y, color);
                particles[i] = p;
                if (p is IVisualizable)
                {
                    visualizables[i] = p as IVisualizable;
                }
            }
            visualizables[size] = domain;
        }

        public void Add(AbstractParticle p, int idx)
        {
            particles[idx] = p;
        }

        private void Rendering() //clears and draws everything again
        {
            Console.Clear();
            foreach (IVisualizable item in visualizables)
            {
                item.Show();
            }
        }

        private void UpdateParticles(int dt) //particle positions
        {
            foreach (AbstractParticle p in particles)
            {
                p.Update(dt, this.domain);
                if (p is RainbowParticle)
                {
                    ((RainbowParticle)p).UpdateColor();
                }
            }
        }
        
        public void Run()
        {
            while (true)
            {
                Rendering();
                UpdateParticles(1); //Speed of particles
                System.Threading.Thread.Sleep(25); //Repeating time
            }
        }
    }
}