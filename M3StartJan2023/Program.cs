namespace M3StartJan2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hva heter du? ");
            //var name = Console.ReadLine();

            //Console.Write("I hvilket år ble du født? ");
            //var yearStr = Console.ReadLine();
            //var year = Convert.ToInt32(yearStr);

            var name = MyConsole.Ask("Hva heter du? ");
            var year = MyConsole.AskForInt("I hvilket år ble du født? ");

            var age = 2023 - year;
            Console.WriteLine($"Hei, {name}!");
            Console.WriteLine($"Du er {age} år gammel.");
        }

        

        //static void Main(string[] args)  //  function Main(args)
        //{
        //    var list = new ArrayList();

        //    Console.WriteLine("Hello, World! ");
        //    //Console.WriteLine(args[0]);
        //    var n = 7;
        //    DoubleAndWrite(n);


        //    var a = 7 * 2 + 7;
        //    var temp = a * 2 + 7;
        //    var b = temp;
        //    var c = temp*2;
        //}

        //static void DoubleAndWrite(int n)
        //{
        //    var value = Double(n);
        //    Console.WriteLine(value);
        //}


        //static int Double(int a)
        //{
        //    return a * 2;
        //}
    }
}