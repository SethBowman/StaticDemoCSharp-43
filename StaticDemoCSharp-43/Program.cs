namespace StaticDemoCSharp_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //var math = new MathHelper();

            var added = MathHelper.Add(2, 2);
            Console.WriteLine(added);

            var roomOne = new Classroom();
            roomOne.RoomNumber = 1;

            Classroom.Subject = "C#";

            Console.WriteLine(Classroom.Subject);

            var roomTwo = new Classroom();
            roomTwo.RoomNumber = 2;

            Classroom.Subject = "Java";

            Console.WriteLine(Classroom.Subject);

            Greet("seth");

        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
