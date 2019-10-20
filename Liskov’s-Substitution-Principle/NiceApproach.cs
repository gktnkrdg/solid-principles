using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Liskov_s_Substitution_Principle
{
    class NiceApproach
    {
        class Bird
        {

        }
        class FlyingBirds : Bird
        {
            void Fly()
            {

            }
        }
        class Eagle : FlyingBirds
        {

        }
        class Ostrich : Bird
        {

        }
    }
}
