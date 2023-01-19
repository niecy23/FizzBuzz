public string FizzBuzz (int number)
{
    var answer = "";
    if (number % 3 == 0)
    {
        answer = "fizz";
    }
    if (number % 5 == 0)
    {
        answer += "buzz";
    }

    return answer;
}

//This is what I used is VS to make it actually work
// namespace FizzBuzz
// {
//     class Program
//     {
//         public static string FizzBuzz(int number)
//         {
//             var answer = "";
//             if (number % 3 == 0)
//             {
//                 answer = "fizz";
//             }
//             if (number % 5 == 0)
//             {
//                 answer += "buzz";
//             }

//             return answer;
//         }

//         static void Main(string[] args)
//         {
//             Console.WriteLine(FizzBuzz(15));
//         }
//     }
// }