using System;

namespace CatSportEnf
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            string Cat;

            Console.WriteLine("Entrez votre age:");
            Age = Convert.ToInt32(Console.ReadLine());

            MethodeDuProjet MesOutils = new MethodeDuProjet();
            MesOutils.CatSportEnf(Age, out Cat);

            Console.WriteLine($"Vous êtes dans la catégorie: {Cat}");
            Console.ReadLine();
        }
    }
}
