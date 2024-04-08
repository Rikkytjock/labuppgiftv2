using ConnectFour;
using Xunit;

public class ConnectFourTests
{
    [Fact]
    public void CheckForWin_NoWinner_EmptyBoard()
    {
        // Arrange
        var gameState = new GameState();

        // Act
        var result = gameState.CheckForWin();

        // Assert
        Assert.Equal(GameState.WinState.No_Winner, result);
    }

    [Fact]
    public void CheckForWin_TieGame()
    {
        // Arrange
        var gameState = new GameState();

        // Set up the game state to represent a tie game
        gameState.TheBoard = Enumerable.Repeat(3, 42).ToList();

        // Act & Assert
        Assert.Equal(GameState.WinState.Tie, gameState.CheckForWin());
    }
}
