using System;
namespace Lab10FiveCard

{ class Program { static void Main(string[] args)
        { Console.OutputEncoding = System.Text.Encoding.Unicode;
            FiveCardDraw fiveCardDraw = new FiveCardDraw();
            fiveCardDraw.PlayRound(); Console.ReadLine();


        }
    }
}