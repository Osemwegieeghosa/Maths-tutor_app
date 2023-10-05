// using System;
// using MathsTutor;
// using Xunit;
// // 
// public class MathsProblemTests
// {
//     [Fact]
//     public void TestDealThreeCards()
//     {
//         // Arrange
//         var expectedCards = 3;

//         // Act
//         MathsProblem.DealThreeCards();
//         var actualCards = Console.OutputEncoding;

//         // Assert
//         Assert.Contains(expectedCards.ToString(), (System.Collections.Generic.IEnumerable<string>)actualCards);
//     }

//     [Fact]
//     public void TestDealFiveCards()
//     {
//         // Arrange
//         var expectedCards = 5;

//         // Act
//         MathsProblem.DealFiveCards();
//         var actualCards = Console.OutputEncoding;

//         // Assert
//         Assert.Contains(expectedCards.ToString(), (System.Collections.Generic.IEnumerable<string>)actualCards);
//     }

//     [Theory]
//     [InlineData(2, "+", 3, "*", 5, "/", 2, 1)]
//     [InlineData(1, "+", 2, "*", 3, "/", 2, 2)]
//     [InlineData(5, "-", 3, "/", 3, "+", 2, 5)]
//     public void TestEvaluateExpression(int card1Value, string card2Suit, int card3Value, 
//                                        string card4Suit, int card5Value, string card6Suit, 
//                                        int card7Value, int expected)
//     {
//         // Arrange
//         var card1 = new Card(card1Value, 1);
//         var card2 = new Card(0, Card.Suits[card2Suit]);
//         var card3 = new Card(card3Value, 1);
//         var card4 = new Card(0, Card.Suits[card4Suit]);
//         var card5 = new Card(card5Value, 1);
//         var card6 = new Card(0, Card.Suits[card6Suit]);
//         var card7 = new Card(card7Value, 1);

//         // Act
//         var actual = MathsProblem.EvaluateExpression(card1, card2, card3, card4, card5, card6, card7);

//         // Assert
//         Assert.Equal(expected, actual);
//     }
// }
