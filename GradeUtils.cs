using static System.Console;
namespace SchoolGrade;

public class GradeUtils
{
    public static float Atoi(string? s)
    {
        return (float.TryParse(s, out var f) ? f : 0f);
    }

    private static float GetAverage(float[] arr)
    {
        if (arr.Length == 0)
            return (0);
        return (arr.Sum() / arr.Length);
    }

    private float GetMin(float[] arr)
    {
        if (arr.Length == 0)
            return (0);

        var min = arr[0];
            
        foreach (var t in arr)
            if (t < min)
                min = t;
        return (min);
    }

    private float GetMax(float[] arr)
    {
        if (arr.Length == 0)
            return (0);

        var max = arr[0];
            
        for (var i = 0; i < arr.Length; i++)
            if (arr[i] > max)
                max = arr[i];
        return (max);
    }
        
    public void ShowArray(float[] arr)
    {
        WriteLine("=============All Grades============");
        for (var i = 0; i < arr.Length; i++)
        {
            WriteLine($"Grade {i + 1}    : {arr[i]}v");
        }
        WriteLine("**********===============**********");
        WriteLine($"Avarage         : {GetAverage(arr)}v");
        WriteLine($"Highest grade   : {GetMax(arr)}v");
        WriteLine($"Lowest grade    : {GetMin(arr)}v");
        WriteLine("==================================");
    }
        
    public static void FillArray(float[] arr)
    {
        for (var i = 0; i < arr.Length; i++)
        {
            Write($"insert grade {i + 1}:  ");
            arr[i] =  Atoi(ReadLine());
            Clear();
        }
        
    }
    
}