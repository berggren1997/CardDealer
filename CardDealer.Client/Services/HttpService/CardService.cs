using CardDealer.Shared.Dto;
using CardDealer.Shared.Dto.CardHand;
using System.Net.Http.Json;
using System.Text.Json;

namespace CardDealer.Client.Services.HttpService
{
    /// <summary>
    /// This class is used for sending HTTP-Requests to the API
    /// </summary>
    public class CardService : ICardService
    {
        private readonly HttpClient _httpClient;

        public CardService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// GET request
        /// </summary>
        /// <returns></returns>
        public async Task<List<CardHandDto>> GetCardHands()
        {
            var response = await _httpClient
                .GetFromJsonAsync<List<CardHandDto>>("/api/cardhand");
            return response;
        }

        /// <summary>
        /// sends a GET to the api 
        /// </summary>
        /// <returns>deck of cards</returns>
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

        /// <summary>
        /// sends a POST request to save cardhand the api
        /// </summary>
        /// <param name="cardHandDto"></param>
        /// <returns></returns>
        public async Task<bool> SaveCardHand(CardHandDto cardHandDto)
        {
            var response = await _httpClient.PostAsJsonAsync("/api/cardhand", cardHandDto);

            return response.IsSuccessStatusCode;
        }

        /// <summary>
        /// shuffles a deck of cards using Fisher–Yates algorithm
        /// </summary>
        /// <param name="cardsToShuffle"></param>
        /// <returns></returns>
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
