namespace DeckOfCards.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DetermineWinner()
        {
            //Arrange
            int player1Score = 1;
            int player2Score = 2;
            var determineWinner = new DetermineWinner();
            var determineWinnerREsult= determineWinner.DetermineWinnerResult(player1Score, player2Score);

            //Act
            var result = determineWinnerREsult;

            //Assert
            Assert.Equal("Player 2 is the winner!", result.ToString());
        }

        [Fact]
        public void CompareCards()
        {
            //Arrange
            int player1Score = 1;
            int player2Score = 2;
            int rounds = 1;

            List<int> deckofCards = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 };

            List<int> player1Cards = deckofCards.GetRange(0, deckofCards.Count / 2);
            List<int> player2Cards = deckofCards.GetRange(deckofCards.Count / 2, deckofCards.Count / 2);

            var compareCards = new CompareCards();
            var compareCardsResult = compareCards.CompareCard(player1Cards, player2Cards,rounds,player1Score, player2Score);

            //Act
            var result = compareCardsResult;

            //Assert
            Assert.Equal(2, result.Count());
            Assert.Equal(1, result[0]);
            Assert.Equal(3, result[1]);

        }

    }
}