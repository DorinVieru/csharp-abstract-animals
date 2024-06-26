﻿using System;
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

    // Interfaccia per il volo
    public interface IVolante
    {
        void Vola();
    }

    // Interfaccia per il nuoto
    public interface INuotante
    {
        void Nuota();
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
    public class Passerotto : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Twit Twit");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia semi/cereali");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    // Classe Aquila
    public class Aquila : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("Un verso che acusticamente è intenso ed è molto acuto");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia carne");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!!");
        }
    }

    // Classe Delfino
    public class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("Ultrasuoni");
        }

        public override void Mangia()
        {
            Console.WriteLine("Mangia pesce");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
    }
}
