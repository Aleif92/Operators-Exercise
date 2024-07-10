namespace OperatorExercise
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            
            //Exercise 1
            int a = 17;
            int b = 4;
            int sum = a + b;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} with a remainder of {remainder}.");
            Console.WriteLine("what is the radius?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"This is the area of your circle:" + AreaOfCircle(radius));
            
        }
        //defining area of circle method
        public static double  AreaOfCircle(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
    }
}
