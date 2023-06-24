namespace ConsoleApp3
{
    class circle
    {
        public int r;
        public float p = 3.14f;
        public static float Area(int r, float p)
        {
            float area = r * r * p;
            return area;
        }

        public static float Mohit(int r, float p)
        {
            float mohit = 2 * r * p;
            return mohit;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            circle circle1 = new circle();
            circle1.r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area is: {0}", circle.Area(circle1.r, circle1.p));
            Console.WriteLine("Mohit is: {0}", circle.Mohit(circle1.r, circle1.p));

            Console.ReadKey();
        }
    }
}