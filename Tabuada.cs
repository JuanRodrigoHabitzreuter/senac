namespace IntroCSharp
{
    public class Tabuada
    {
        public static void CalculeATabuada()
        {
            int multiplicationTable;
            Console.WriteLine("Inform the multiplication table: ");
            multiplicationTable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{multiplicationTable} x {j} = {multiplicationTable * j}");
            }
        }
    }
}