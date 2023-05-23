namespace IntroCSharp
{
    public class Imc
    {
        public static void CalculeOIMC() {
            char gender;
            double height = 0;

            do
            {
                Console.WriteLine("Tell you are: (m) for man or (w) for woman: ");
                gender = Convert.ToChar(Console.ReadLine());
            } while (gender != 'm' && gender != 'M' && gender != 'w' && gender != 'W');

            Console.WriteLine("Report your height:");
            height = Convert.ToDouble(Console.ReadLine());

            if (gender == 'm' || gender == 'M')
            {
                Console.WriteLine($"Your IMC is: {((72.7 * height) - 58)}");
            }
            else if (gender == 'w' || gender == 'W')
            {
                Console.WriteLine($"Your IMC is: {((62.1 * height) - 44)}");
            }
        }
    }
}