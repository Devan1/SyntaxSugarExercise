using System;

namespace SyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            //Explicit Typing
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
                Console.Write(response);
            }
            else
            {
                response = answer + " greater than or equal to nine";
                Console.Write(response);
            }
            Console.WriteLine();
            
            
            
            //Inferred Typing
            var answerInferred = 4;
            var responseInferred = "";

            if(answer < 9)
            {
                responseInferred = answerInferred + " is less than nine";
                Console.Write(responseInferred);
            }
            else
            {
                responseInferred = answerInferred + " greater than or equal to nine";
                Console.Write(responseInferred);
            }
            Console.WriteLine();

            
            
            //Inline If/Ternary Operator Typing
            var answerInline = 4;
            var responseInline = (answerInline < 9) ? answerInline + " is less than nine" : answerInline + " greater than or equal to nine";
            Console.Write(responseInline);


        }
    }
}
