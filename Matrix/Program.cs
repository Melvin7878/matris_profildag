using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)

         
            float[,] matrisA = new float[2, 2];  //Matris A, notering: lägg till efter "new float" storleken på matrisen

            matrisA[0, 0] = 1;
            matrisA[0, 1] = 2;
            matrisA[1, 0] = 3;
            matrisA[1, 1] = 4;

            float[,] matrisB = new float[2, 2];  //Matris B, notering: lägg till efter "new float" storleken på matrisen

            matrisB[0, 0] = 3;
            matrisB[0, 1] = 4;
            matrisB[1, 0] = 5;
            matrisB[1, 1] = 6;

            float[,] matrisC = new float[2, 2]; //MatrisC som ska innehålla additionen mellan matris A och B

            for (int col = 0; col < 2; col++)
            {
                for (int row = 0; row < 2; row++)
                {
                    matrisC[row, col] = matrisA[row, col] + matrisB[row, col];                //Identifierar kollumnenerna och raderna av matrisen
                }
            }

            MatrixChecker.CheckAddition(matrisA[0, 0], matrisA[0, 1], matrisA[1, 0], matrisA[1, 1],      //Måste sätta upp HELA matris-uträkningen eller matrisen
                matrisB[0, 0], matrisB[0, 1], matrisB[1, 0], matrisB[1, 1],
                matrisC[0, 0], matrisC[0, 1], matrisC[1, 0], matrisC[1, 1]);



            Draw2x2Matrix(matrisC[0, 0], matrisC[0, 1], matrisC[1, 0], matrisC[1, 1]);

            Console.WriteLine();


            float radie = 3.14f;
            float calculation = radie * (float)Math.PI / radie;
            float result = calculation;


            float[,] rotationsMatris1 = new float[2, 2];          //Rotatinsmatris

            rotationsMatris1[0, 0] = (float)Math.Cos(result);               //C-style cast "(float)" före uträkning
            rotationsMatris1[0, 1] = (float)Math.Sin(result);
            rotationsMatris1[1, 0] = (float)-Math.Sin(result);
            rotationsMatris1[1, 1] = (float)Math.Cos(result);

            MatrixChecker.CheckRotationMatrix(result, rotationsMatris1[0, 0], rotationsMatris1[0, 1], rotationsMatris1[1, 0], rotationsMatris1[1, 1]);
           
            Draw2x2Matrix(rotationsMatris1[0, 0], rotationsMatris1[0, 1], rotationsMatris1[1, 0], rotationsMatris1[1, 1]);



            matrisA[0, 0] = 1;
            matrisA[0, 1] = 2;
            matrisA[1, 0] = 3;
            matrisA[1, 1] = 4;

            matrisB[0, 0] = 5;
            matrisB[0, 1] = 6;
            matrisB[1, 0] = 7;
            matrisB[1, 1] = 8;


            float[,] matrisCMultiplication = new float[2, 2];

            matrisCMultiplication[0, 0] = matrisA[0, 0] * matrisB[0, 0] + matrisA[0, 1] * matrisB[1, 0];
            matrisCMultiplication[0, 1] = matrisA[0, 0] * matrisB[0, 1] + matrisA[0, 1] * matrisB[1, 1];
            matrisCMultiplication[1, 0] = matrisA[1, 0] * matrisB[0, 0] + matrisA[1, 1] * matrisB[1, 0];
            matrisCMultiplication[1, 1] = matrisA[1, 0] * matrisB[0, 1] + matrisA[1, 1] * matrisB[1, 1];

   
            MatrixChecker.CheckMultiplication(matrisC[0, 0], matrisC[0, 1], matrisC[1, 0], matrisC[1, 1], matrisA[0, 0], 
                matrisA[0, 1], matrisA[1, 0], matrisA[1, 1], matrisB[0, 0], matrisB[0, 1], matrisB[1, 0], matrisB[1, 1]);

            Draw2x2Matrix(matrisCMultiplication);

            Console.ReadKey();

            



        }
    }
}
