
class Program
{
    static void Main(string[] args)
    {
        var ss = saxeli.ragaca.perimetri(1);
        var dd = partobe.dog.partobi(1,2,3);
        Console.WriteLine(dd);
    }
}

namespace saxeli
{
    public class ragaca
    {
        //circle
        public static double perimetri(int a)
        {
            return 2 * a * Math.PI;
        }
        //rectangle
        public static double perimetri(int a, int b)
        {
            return 2 * (a + b);
        }
        //triangle
        public static double perimetri(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}

namespace gvari
    {
    public class ragaca
    {
        //circle
        public static double perimetri(int a)
        {
            return 2 * a * Math.PI;
        }
        //rectangle
        public static double perimetri(int a, int b)
        {
            return 2 * (a + b);
        }
        //triangle
        public static double perimetri(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}


namespace partobe
{
    public class dog
    {
        //circle
        public static double partobi(int a)
        {
            return 2 * a * Math.PI * a;
        }
        //rectangle
        public static double partobi(int a, int b)
        {
            return 2 * (a * b);
        }
        //triangle
        public static double partobi(int a, int b, int c)
        {
            return (a % b) * a * b;
        }
    }
}