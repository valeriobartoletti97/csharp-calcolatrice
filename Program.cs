namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dover scrivere lo stesso metodo per tipi di parametro diversi applica il principio di OVERLOADING
            Console.WriteLine(CalcoliHelper.SommaNumeri(3, 2));
            Console.WriteLine(CalcoliHelper.SommaNumeri(3.7, 2.2));
            Console.WriteLine(CalcoliHelper.DifferenzaNumeri(3, 2));
            Console.WriteLine(CalcoliHelper.DifferenzaNumeri(3.7, 2.2));
            Console.WriteLine(CalcoliHelper.MoltiplicaNumeri(3, 2));
            Console.WriteLine(CalcoliHelper.MoltiplicaNumeri(3.7,2.2));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(6));
            Console.WriteLine(CalcoliHelper.ValoreAssoluto(-6));
            Console.WriteLine(CalcoliHelper.NumeroMinore(3, 2));
            Console.WriteLine(CalcoliHelper.NumeroMinore(3.7, 2.2));
            Console.WriteLine(CalcoliHelper.NumeroMaggiore(3, 2));
            Console.WriteLine(CalcoliHelper.NumeroMaggiore(3.7, 2.2));
            Console.WriteLine(CalcoliHelper.ElevaAPotenza(2, 2));
            Console.WriteLine(CalcoliHelper.ElevaAPotenza(0, 2));
            Console.WriteLine(CalcoliHelper.ElevaAPotenza(2, 0));
            Console.WriteLine(CalcoliHelper.ElevaAPotenza(2, -3));
        }
    }
}
