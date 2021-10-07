using System;
using System.Collections.Generic;
using System.Text;

namespace CatSportEnf
{
    public struct MethodeDuProjet
    {
        public void CatSportEnf(int Age,out string Cat)
        {
            if (Age <= 5)
            {
                Cat = "Pas de catégorie";
            }
            else if (Age <= 7)
            {
                Cat = "Poussin";
            }
            else if (Age <= 9)
            {
                Cat = "Pupille";
            }
            else if (Age <= 11)
            {
                Cat = "Minime";
            }
            else if (Age <= 14)
            {
                Cat = "Cadet";
            }
            else
            {
                Cat = "Pas de catégorie";
            }
        }
    }
}
