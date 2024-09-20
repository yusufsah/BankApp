using Microsoft.AspNetCore.Mvc;

namespace BankPresentation.Controllers
{
    public class ExChangeController : Controller
    {
        public async Task<IActionResult> Index()
           {



            #region
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=USD&to=TRY&q=1.0"),
                Headers =
              {
              { "x-rapidapi-key", "9201068f48msh12dac245dec02e8p19a521jsnac85f87f2674" },
                { "x-rapidapi-host", "currency-exchange.p.rapidapi.com" },
                },
                 };
               using (var response = await client.SendAsync(request))
                {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                
                ViewBag.usdtotry = body;
                 }
            #endregion

            #region
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=EUR&to=TRY&q=1.0"),
                Headers =
              {
              { "x-rapidapi-key", "9201068f48msh12dac245dec02e8p19a521jsnac85f87f2674" },
                { "x-rapidapi-host", "currency-exchange.p.rapidapi.com" },
                },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body = await response2.Content.ReadAsStringAsync();

                ViewBag.eurtotry = body;
            }
            #endregion

            #region
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-exchange.p.rapidapi.com/exchange?from=GBP&to=TRY&q=1.0"),
                Headers =
              {
              { "x-rapidapi-key", "9201068f48msh12dac245dec02e8p19a521jsnac85f87f2674" },
                { "x-rapidapi-host", "currency-exchange.p.rapidapi.com" },
                },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body = await response3.Content.ReadAsStringAsync();

                ViewBag.gbptotry = body;
            }
            #endregion

            return View();
        }
    }
}
