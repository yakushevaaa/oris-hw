using Fuck_API.Model;
using HtmlAgilityPack;
using System.Net.Http;

namespace Fuck_API.Services
{
    public class ParsingService : IParsingService
    {
        private readonly HttpClient httpClient = new();

        private readonly List<string> HeroNames = new()
        {
            "mirana",
            "marci",
            "templar_assassin"

        };

        public async Task<List<Item>> Parse(int pageNumber, int pageSize)
        {
            var cards = new List<Item>();
            var totalItemsNeeded = pageNumber * pageSize;
            var pagesPerHero = (int)Math.Ceiling((double)totalItemsNeeded / HeroNames.Count / 10);

            foreach (var hero in HeroNames)
                for (var page = 1; page <= pagesPerHero; page++)
                {
                    var url = page == 1
                        ? $"https://steamcommunity.com/market/search?q=&category_570_Hero%5B%5D=tag_npc_dota_hero_{hero}&category_570_Slot%5B%5D=any&category_570_Type%5B%5D=any&appid=570"
                        : $"https://steamcommunity.com/market/search?q=&category_570_Hero%5B%5D=tag_npc_dota_hero_{hero}&category_570_Slot%5B%5D=any&category_570_Type%5B%5D=any&appid=570#p{page}_popular_desc";

                    var heroItems = await ParsePage(url, hero);
                    cards.AddRange(heroItems);
                }

            var rnd = new Random();
            var shuffledItems = cards.OrderBy(x => rnd.Next()).ToList();

            return shuffledItems.Take(totalItemsNeeded).ToList();
        }

        private async Task<List<Item>> ParsePage(string url, string hero)
        {
            var pageItems = new List<Item>();

            var html = await httpClient.GetStringAsync(url);
            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var cardNodes = doc.DocumentNode.SelectNodes("//div[contains(@id, 'result_') and not(contains(@id, 'resultlink_'))]");

            if (cardNodes != null)
            {
                for (int i = 0; i < cardNodes.Count; i++)
                {
                    var node = cardNodes[i];
                    var idParts = node.Id.Split('_');

                    if (idParts.Length < 2)
                        continue;

                    var id = idParts[1];
                    var imgNode = node.SelectSingleNode($".//*[@id=\"result_{id}_image\"]");
                    var nameNode = node.SelectSingleNode($".//span[@id='result_{id}_name']");
                    var gameNode = node.SelectSingleNode(".//span[contains(@class, 'market_listing_game_name')]");
                    var costNode = node.SelectSingleNode(".//span[contains(@class, 'market_table_value')]/span[contains(@class, 'normal_price')]");
                    var amountNode = node.SelectSingleNode(".//span[contains(@class, 'market_listing_num_listings')]");

                    if (imgNode == null || nameNode == null || gameNode == null || costNode == null || amountNode == null)
                        continue;

                    var card = new Item
                    {
                        Img = imgNode.GetAttributeValue("src", string.Empty),
                        Name = nameNode.InnerText.Trim(),
                        Game = gameNode.InnerText.Trim(),
                        Cost = costNode.InnerText.Trim(),
                        Amount = amountNode.InnerText.Trim(),
                        HeroName = hero
                    };

                    pageItems.Add(card);
                }
            }

            return pageItems;
        }
    }
}