using static System.Console;

namespace SchoolGrade
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var g = new GradeUtils();
            
            WriteLine("How much grades do you want to fill?");
            var arr = new float[(int)GradeUtils.Atoi(ReadLine())];
            GradeUtils.FillArray(arr);
            try
            {
                g.ShowArray(arr);
            }
            catch (Exception)
            {
                WriteLine("General Error");
                throw;
            }
        }
    }
}

