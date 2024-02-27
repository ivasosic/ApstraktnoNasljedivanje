using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApstraktnoNasljeđivanje
{
    internal class Program
    {

        public abstract class Geometrijski_lik
        {
            public string m_naziv;
            public abstract double Povrsina();
            public void Ispis()
            {
                Console.WriteLine("Naziv: ", m_naziv);
            }

        }

        public class Krug : Geometrijski_lik
        {
            public double m_radius;
            public Krug(string naziv, double radius)
            {
                m_naziv = naziv;
                m_radius = radius;
            }
            
        public override double Povrsina()
            {
                return m_radius * m_radius * 3.14;
            }

        }

            static void Main(string[] args)
        {
            Geometrijski_lik gl;
            Krug k = new Krug("Pravilan", 2.45);

            gl = k;
            gl.Ispis();

           
            double rez = gl.Povrsina();

            Console.WriteLine("Povrsina: {0}", rez);
            Console.ReadLine();

             Console.ReadKey();

        }

    }
}

   
