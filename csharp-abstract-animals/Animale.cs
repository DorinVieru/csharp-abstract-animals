using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("Zzzzzzzzzzzzzzzzzzzzzz");
        }

        public abstract void Verso();
        public abstract void Mangia();
    }

    // Classe Cane
    public class Cane : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Bau Bau Bau");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia carne e verdure");
        }
    }

    // Classe Passerotto
    public class Passerotto : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Twit Twit");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia semi/cereali");
        }
    }

    // Classe Aquila
    public class Aquila : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Un verso che acusticamente è intenso ed è molto acuto");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia carne");
        }
    }

    // Classe Delfino
    public class Delfino : Animale
    {
        public override void Verso()
        {
            Console.WriteLine("Ultrasuoni");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia pesce");
        }
    }
}
