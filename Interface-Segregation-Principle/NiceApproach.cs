using System;
using System.Collections.Generic;
using System.Text;

namespace S.O.L.I.D.Interface_Segregation_Principle
{
    class NiceApproach
    {
        interface IToy
        {
            void SetPrice(double price);
        }
        interface IFlyable
        {
            void Fly();
        }
        class ToyHouse : IToy
        {
            double price;
            public void SetPrice(double price)
            {
                this.price = price;
            }
        }

        class ToyPlane : IToy, IFlyable
        {
            double price;
            public void SetPrice(double price)
            {
                this.price = price;
            }
            public void Fly()
            {
                //
            }
        }
    }
}
