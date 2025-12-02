using static System.Console;

namespace SchoolGrade
{
    internal static class Program
    {
        private static float Atoi(string? s)
        {
                return (float.TryParse(s, out var f) ? f : 0f);
        }

        private static float GetAverage(float[] arr)
        {
            if (arr.Length == 0)
                return (0);

            var sum = 0f;
            
            for (var i = 0; i < arr.Length; i++)
                sum += arr[i];
            return (sum / arr.Length);
        }
        
        private static float GetMin(float[] arr)
        {
            if (arr.Length == 0)
                return (0);

            var min = arr[0];
            
            for (var i = 0; i < arr.Length; i++)
                if (arr[i] < min)
                    min = arr[i];
            return (min);
        }
        
        private static float GetMax(float[] arr)
        {
            if (arr.Length == 0)
                return (0);

            var max = arr[0];
            
            for (var i = 0; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];
            return (max);
        }
        
        private static void ShowArray(float[] arr)
        {
            WriteLine("=============All Grades============");
            for (var i = 0; i < arr.Length; i++)
            {
                WriteLine($"{arr[i]}v");
            }
            WriteLine("**********===============**********");
            WriteLine($"Max grade : {GetMax(arr)}v");
            WriteLine($"Min grade : {GetMin(arr)}v");
            WriteLine($"Avarage   : {GetAverage(arr)}v");
            WriteLine("==================================");
        }
        
        private static void FillArray(float[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Write($"insert grade {i + 1}:  ");
                arr[i] =  Atoi(ReadLine());
                Clear();
            }
 
        }

        private static void Main(string[] args)
        {
            WriteLine("How much grades do you want to fill?");
            var arr = new float[(int)Atoi(ReadLine())];
            FillArray(arr);
            try
            {
                ShowArray(arr);
            }
            catch (Exception)
            {
                WriteLine("General Error");
                throw;
            }
        }
    }
}

