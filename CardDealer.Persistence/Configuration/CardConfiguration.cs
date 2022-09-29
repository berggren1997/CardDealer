using CardDealer.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CardDealer.Persistence.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        private List<string> cardSuits = new() { "Hearts", "Diamonds", "Clubs", "Spades" };
        private List<string> cardValues = new() { "Two", "Three", "Four", "Five",
        "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"};
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            //List<Card> cards = new();
            for (int i = 0; i < cardSuits.Count; i++)
            {
                for (int j = 0; j < cardValues.Count; j++)
                {
                    builder.HasData(new Card
                    {
                        Id = Guid.NewGuid(),
                        Suit = cardSuits[i],
                        Value = cardValues[j]
                    });
                }
            }
        }
    }
}
