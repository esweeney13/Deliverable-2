namespace Deliverable_2_
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is an A");
                }

                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}