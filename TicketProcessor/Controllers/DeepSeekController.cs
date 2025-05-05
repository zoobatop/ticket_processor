using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Constants;
using TicketProcessor.Models;

namespace DeepSeekApi.Controllers 
{
    [ApiController]
    [Route("api/deepseek")]
    public class DeepSeekController : ControllerBase
    {
        [HttpPost("chamada")]
        public async Task<IActionResult> Chamada([FromBody] DeepSeekRequest request)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {AppConstants.DeepSeekKey.DefaultKey}");

            var requestBody = new
            {
                model = "deepseek/deepseek-chat:free",
                messages = new[]
                {
                    new { role = "user", content = request.Question }
                }
            };

            string jsonData = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(AppConstants.DeepSeekKey.DefaultApi, content);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                var deepSeekResponse = JsonSerializer.Deserialize<DeepSeekApiResponse>(responseContent);
                
                var formattedResponse = new FormattedResponse
                {
                    Message = deepSeekResponse?.Choices?.FirstOrDefault()?.Message?.Content
                };
                
                return Ok(formattedResponse);
            }
            else
            {
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
        }
    }
}