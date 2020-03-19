using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drob
{
    class Fraction
    {
        int H { get; set; }
        int Z { get; set; }
        public Fraction(int H, int Z)
        {
            this.H = H;
            this.Z = Z;
        }
        public Fraction()
        {

        }
        public  Fraction Sokrasienie( )
        {
           
            for (int i = this.H; i > 0; i--)
            {
                if(this.H%i==0 && this.Z % i == 0)
                {
                    this.H = H / i;
                    this.Z = Z / i;
                }
                break;
            }
            return this;
        }
        public static Fraction operator + (Fraction X, Fraction Y)
        {
            Fraction result = new Fraction();
         result.H = (X.H * Y.Z + Y.H * X.Z);
             result.Z = ( X.Z * Y.Z);
            result.Sokrasienie();
            return result;
        }
        public static Fraction operator -(Fraction X, Fraction Y)
        {
            Fraction result = new Fraction();
            result.H = (X.H * Y.Z - Y.H * X.Z);
            result.Z = (X.Z * Y.Z);
            result.Sokrasienie();
            return result;
        }
        public static Fraction operator * (Fraction X, Fraction Y)
        {
            Fraction result = new Fraction();
         result.H = (X.H *Y.H);
             result.Z = ( X.Z * Y.Z);
            result.Sokrasienie();
            return result;
        }
        public static Fraction operator /(Fraction X, Fraction Y)
        {
            Fraction result = new Fraction();
            result.H = (X.H * Y.Z );
            result.Z = (X.Z * Y.H);
            result.Sokrasienie();
            return result;
        }
        public override bool Equals(object K)
        {
            if(K==null || !this.GetType().Equals(K.GetType()))
            {
                return false;

            }
            else
            {
                Fraction F = (Fraction)K;
                return (this.H == F.H) && (this.Z == F.Z);
            }
            
        }
        public override string ToString()
        {
            return $"{H}/{Z}";
        }
    }
}
