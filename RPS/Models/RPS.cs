using System;
using System.Collections.Generic;

namespace RPS.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set; }
    public bool Draw { get; set; }

    public Game(string p1Choice, string p2Choice)
    {
      Player1 = p1Choice.ToLower();
      Player2 = p2Choice.ToLower();
      Draw = false;
    }

    public string GetWinner(){
      if(Player1 == "rock" && Player2 == "scissors")
      {
        return "Player 1 Wins!";
      }
      else if (Player1 == "scissors" && Player2 == "paper")
      {
        return "Player 1 Wins!";
      }
      else if (Player1 == "paper" && Player2 == "rock")
      {
        return "Player 1 Wins!";
      }
      else if (Player1 == Player2)
      {
        Draw = true;
        return "Draw";
      }
      else 
      {
        return "Player 2 Wins!";
      }
    }
  }
}