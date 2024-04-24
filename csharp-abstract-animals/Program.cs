namespace csharp_abstract_animals
{
    internal class Program
    {
        public static void FaiVolare(IVolante animale)
        {
            animale.Vola();
        }

        public static void FaiNuotare(INuotante animale)
        {
            animale.Nuota();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
