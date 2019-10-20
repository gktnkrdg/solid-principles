using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Liskovs_Substitution_Principle
{
    class BadApproach
    {
        class Bird
        {
            void Fly()
            {

            }
        }
        class Eagle : Bird
        {

        }
        class Ostrich : Bird
        {

        }
    }
}
