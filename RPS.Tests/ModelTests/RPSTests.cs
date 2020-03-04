using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS.Models;

namespace RPS.Tests
{
  [TestClass]
  public class RPSTests
  {
    [TestMethod]
    public void Game_GameConstructor_NewGame()
    {
      // Arrange
      Game newGame = new Game("rock", "PapeR");
      // Act
      string result1 = newGame.Player1;
      string result2 = newGame.Player2;
      bool result3 = newGame.Draw;
      // Assert
      Assert.AreEqual(result1, "rock");
      Assert.AreEqual(result2, "paper");
      Assert.AreEqual(result3, false);
    }

    [TestMethod]
    public void Game_GetWinner_Player1Wins()
    {
      // Arrange
      Game newGame = new Game("rock", "scissors");
      // Act
      string result = newGame.GetWinner();
      // Assert
      Assert.AreEqual(result, "Player 1 Wins!");
    }

    [TestMethod]
    public void Game_GetWinner_Draw()
    {
      // Arrange
      Game newGame = new Game("rock", "rock");
      // Act
      string result = newGame.GetWinner();
      // Assert
      Assert.AreEqual(result, "Draw");
    }

    [TestMethod]
    public void Game_GetWinner_Player2Wins()
    {
      // Arrange
      Game newGame = new Game("scissors", "rock");
      // Act
      string result = newGame.GetWinner();
      // Assert
      Assert.AreEqual(result, "Player 2 Wins!");
    }
  }
}