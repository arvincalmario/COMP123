
namespace homework04_complex
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("hello world");
            Complex.TestHarness();
        }

    }
    class Complex
    {
        public int Real { get; }
        public int Imaginary { get; }
        public double Argument { get; }
        public double Modulus { get; }
        public static Complex Zero { get; }

        public Complex(int real = 0, int imaginary = 0)
        {
            Real = real;
            Imaginary = imaginary;

            Modulus = Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));
            Argument = Math.Atan(Imaginary / Real);

        }
        public override string ToString()
        {
            
            return $"({Real} , {Imaginary})";
        }
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);

        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {

            bool result = lhs.Real == lhs.Real && lhs.Imaginary == rhs.Imaginary; ;
            return result;
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            bool result = lhs.Real == lhs.Real && lhs.Imaginary == rhs.Imaginary; ;
            return result;
        }
        public static void TestHarness()
        {
            Complex c0 = new Complex(-2, 3);
            Complex c1 = new Complex(-2, 3);
            Complex c2 = new Complex(1, -2);

            Console.WriteLine($"{c0}");
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine($"{c1} + {c2} = {c1 + c2}");
            Console.WriteLine($"{c1} - {c2} = {c1 - c2}");

            Complex c3 = c1 + c2;


            Console.WriteLine($"{c3} in polar form is {c3.Modulus:f2}cis({c3.Argument:f2})");

            Console.WriteLine($"{c0} {(c0 == c1 ? "=" : "!=")} {c1}");
            Console.WriteLine($"{c0} {(c0 == c2 ? "=" : "!=")} {c2}");

        }
    }
}

