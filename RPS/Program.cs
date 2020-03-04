using System;
using System.Collections.Generic;
using RPS.Models;

class Program
{

  public static Game myGame;

  static void Main()
  {
    try
    {
      Console.WriteLine("Welcome to Rock Paper Scissors.");
      string answer1 = Player1Path();
      string answer2 = Player2Path();
      myGame = new Game(answer1, answer2);
      Console.WriteLine(myGame.GetWinner());
    }
    catch (Exception ex)
    {
      Console.WriteLine("Message = {0}", ex.Message);
      Console.WriteLine("Source = {0}", ex.Source);
      Console.WriteLine("StackTrace = {0}", ex.StackTrace);
      Console.WriteLine("TargetSite = {0}", ex.TargetSite);
    }

    string Player1Path()
    {
      Console.WriteLine("Player 1 choose an option. [rock/paper/scissors]");
      string Player1Text = TextCheck(Console.ReadLine().ToLower());
      if(Player1Text == "")
      {
        return Player1Path();
      }
      else
      {
        return Player1Text;
      }
    }

    string Player2Path()
    {
      Console.WriteLine("Player 2 choose an option. [rock/paper/scissors]");
      string Player2Text = TextCheck(Console.ReadLine().ToLower());
      if(Player2Text == "")
      {
        return Player2Path();
      }
      else
      {
        return Player2Text;
      }
    }

    string TextCheck(string playerText)
    { 
      if (playerText == "rock" || playerText == "paper" || playerText == "scissors")
      {
        return playerText;
      }
      else 
      {
        return "";
      }
    }

  }
}