using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Interface_Segregation_Principle
{
    class BadApproach
    {
        interface IToy
        {
            void SetColor(string color);
            void Fly();
        }
        class ToyHouse : IToy
        {
            String color;
            public void SetColor(string color)
            {
                this.color = color;
            }
            public void Fly()
            {
                throw new NotImplementedException();
            }
        }
    }
}
