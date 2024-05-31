using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public double[] SuperLista {get; private set;}
        public SuperList(double[] superLista)
        {
             SuperLista = superLista;
        }

        public struct SuperListaStruct
        {

            public double MinS { get ; }
            public double MaxS { get ; }
            public SuperListaStruct( double minS , double maxS )
            {
                MinS= minS ;
                MaxS = maxS ;
            }

        }
        public void GetMinMax1(out double min1, out double max1)
        {
            min1 = SuperLista[0];
            max1 = SuperLista[0];
            foreach (double i in SuperLista)
            {
                if(i < min1)
                {
                    min1 = i;
                }
                else if( i > max1)
                {
                    max1 = i;
                }
            }
        }

        public SuperListaStruct GetMinMax2()
        {
            double min2 = SuperLista[0];
            double max2 = SuperLista[0];

            foreach ( double i in SuperLista)
            {
                if (i < min2)
                {
                    min2 = i;
                }
                if (i > max2)
                {
                    max2 = i;
                }
            }

            return new SuperListaStruct(min2,max2);
        }

        public (double min, double max) GetMinMax3()
        {
            double min3 = SuperLista[0];
            double max3 = SuperLista[0];
            foreach (double i in SuperLista)
            {
                if (i < min3)
                {
                    min3 = i;
                }
                if (i > max3)
                {
                    max3 = i;
                }
            }
            return (min3, max3);
        }

        public (double Min, double Max) GetMinMax4()
        {
            double min4 = SuperLista[0];
            double max4 = SuperLista[0];
            foreach (double i in SuperLista)
            {
                if (i < min4)
                {
                    min4 = i;
                }
                if (i > max4)
                {
                    max4 = i;
                }
            }
            return (Min: min4, Max: max4);
        }
    }
}