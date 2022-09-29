using CardDealer.Shared.Dto;
using CardDealer.Shared.Dto.CardHand;
using System.Net.Http.Json;
using System.Text.Json;

namespace CardDealer.Client.Services.HttpService
{
    public class CardService : ICardService
    {
        private readonly HttpClient _httpClient;

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CardHandDto>> GetCardHands()
        {
            var response = await _httpClient
                .GetFromJsonAsync<List<CardHandDto>>("/api/cardhand");
            return response;
        }

        public async Task<Stack<CardDto>> GetDeckOfCards()
        {
            var response = await _httpClient.GetAsync("/api/card");

            if (!response.IsSuccessStatusCode) return null;

            var content = await response.Content.ReadAsStringAsync();

            var resultContent = JsonSerializer.Deserialize<List<CardDto>>(content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            ShuffleCardDeck(resultContent);

            Stack<CardDto> result = new();

            resultContent.ForEach(card => result.Push(card));

            return result;
        }

        public async Task<bool> SaveCardHand(CardHandDto cardHandDto)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/cardhand", cardHandDto);

            return response.IsSuccessStatusCode;
        }

        //TODO: Testa denna metod, få en lista, och kolla så att listan inte är likadan
        //TODO: Kolla också så att längden på listan är samma som listan man skicka in
        public List<CardDto> ShuffleCardDeck(List<CardDto> cardsToShuffle)
        {
            Random random = new();

            List<CardDto> listToReturn = cardsToShuffle;

            for (int i = listToReturn.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);

                CardDto tempValue = listToReturn[i];
                listToReturn[i] = listToReturn[j];
                listToReturn[j] = tempValue;
            }
            return listToReturn;
        }
    }
}
