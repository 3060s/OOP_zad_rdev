namespace OOP_zad_rdev
{
    abstract class Figura
    {
        public abstract double Pole();
        public abstract double Obwod();
    }


    class Prostokat : Figura
    {
        private readonly double bok1, bok2;

        public Prostokat(double x, double y)
        {
            this.bok1 = x;
            this.bok2 = y;
        }

        public override double Pole()
        {
            return bok1 * bok2;
        }

        public override double Obwod()
        {
            return (2 * bok1) + (2 * bok2);
        }
    }


    class Trojkat : Figura
    {
        private readonly double bok1, bok2, bok3;

        public Trojkat(double x, double y, double z)
        {
            this.bok1 = x;
            this.bok2 = y;
            this.bok3 = z;
        }

        public override double Pole()
        {
            double s = (bok1 + bok2  + bok3) / 2;
            return Math.Sqrt(s * (s - bok1) * (s - bok2) * (s - bok3));
        }

        public override double Obwod()
        {
            return bok1 + bok2+ bok3;
        }
    }


    class Kolo : Figura
    {
        private readonly double promien;

        public Kolo(double r)
        {
            this.promien = r;
        }

        public override double Pole()
        {
            return 3.14 * (promien * promien);
        }

        public override double Obwod()
        {
            return 2 * 3.14 * promien;
        }
    }
}