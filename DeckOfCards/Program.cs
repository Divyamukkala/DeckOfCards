using DeckOfCards;

// Total number of rounds for comparison
int rounds = 5;

// Initialize player scores
int player1Score = 0;
int player2Score = 0;

// Create a list of even numbers (e.g., 2, 4, 6, 8, ..., up to 22)
List<int> deckofCards = new List<int>() { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22 };

// Shuffle the deck of cards
ShuffleCards shuffleCards = new ShuffleCards(deckofCards);

// Split the cards equally between the two players
List<int> player1Cards = deckofCards.GetRange(0, deckofCards.Count / 2);
List<int> player2Cards = deckofCards.GetRange(deckofCards.Count / 2, deckofCards.Count / 2);
       

Console.WriteLine("Player 1 cards: " + string.Join(", ", player1Cards));
Console.WriteLine("Player 2 cards: " + string.Join(", ", player2Cards));
Console.WriteLine();

// Compare cards for 5 rounds
CompareCards compareCards = new CompareCards();
var result = compareCards.CompareCard(player1Cards, player2Cards, rounds, player1Score, player1Score);


// To Declare the winner
DetermineWinner determineWinner = new DetermineWinner();
var determineWinnerResult = determineWinner.DetermineWinnerResult(result[0], result[1]);
Console.ReadLine();
