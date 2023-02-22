using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RUAP_projekt.Data;
using RUAP_projekt.Models.Entities;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;

namespace RUAP_projekt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FlagsController : Controller
    {

        private readonly FlagsDbContext flagsDbContext;

        public FlagsController(FlagsDbContext flagsDbContext)
        {
            this.flagsDbContext = flagsDbContext;
        }
        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }

        [HttpGet]
        public async Task<IActionResult> GetFlags()
        {
            using (var client = new HttpClient())
            {
                var flag = await (from n in flagsDbContext.Flags
                                  orderby n.Id descending select n).FirstOrDefaultAsync();
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Name", "Landmass", "Zone", "Area", "Population", "Language", "Religion", "Bars", "Stripes", "Colours", "Red", "Green", "Blue", "Gold", "White", "Black", "Orange", "MainHue", "Circles", "Crosses", "Saltires", "Quarters", "Sunstars", "Crescent", "Triangle", "Icon", "Animate", "Text", "TopLeft", "BotRight"},
                                Values =  new string[,] { { $"{flag.Name}", $"{flag.Landmass}", $"{flag.Zone}", $"{flag.Area}", $"{flag.Population}", $"{flag.Language}", $"{flag.Religion}", $"{flag.Bars}", $"{flag.Stripes}", $"{flag.Colours}", $"{flag.Red}", $"{flag.Green}", $"{flag.Blue}", $"{flag.Gold}", $"{flag.White}", $"{flag.Black}", $"{flag.Orange}", $"{flag.MainHue}", $"{flag.Circles}", $"{flag.Crosses}", $"{flag.Saltires}", $"{flag.Quarters}", $"{flag.Sunstars}", $"{flag.Crescent}", $"{flag.Triangle}", $"{flag.Icon}", $"{flag.Animate}", $"{flag.Text}", $"{flag.TopLeft}", $"{flag.BotRight}" },  }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "LNnZI4z4KLhKhGX17Ayf7DMQ4tbUQhjN/A0QSEi28LmuuteujwPLsLng4FQOMV+I+l8UOlLcNivT+AMCI3ziYg=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/6e02f08f163049aea2c79c724f49c848/services/4b8e276e55fd409a8b0a4aaa384676ae/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                return Ok(await response.Content.ReadAsStringAsync());
            }
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [ActionName("GetFlagById")]
        public async Task<IActionResult> GetFlagById([FromRoute] Guid id)
        {
            var flag = await flagsDbContext.Flags.FindAsync(id);

            if(flag == null)
            {
                return NotFound();
            }

            return Ok(flag);
        }

        [HttpPost]
        public async Task<IActionResult> AddFlag(Flag flag)
        {
            flag.Id = Guid.NewGuid();
            await flagsDbContext.Flags.AddAsync(flag);
            await flagsDbContext.SaveChangesAsync();
            
            return CreatedAtAction(nameof(GetFlagById), new { id = flag.Id}, flag);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateFlag([FromRoute] Guid id, [FromBody] Flag updatedFlag)
        {
            var existingFlag = await flagsDbContext.Flags.FindAsync(id);

            if(existingFlag == null)
            {
                return NotFound();
            }

            existingFlag.Bars = updatedFlag.Bars;
            existingFlag.Stripes = updatedFlag.Stripes;
            existingFlag.Red = updatedFlag.Red;
            existingFlag.Green = updatedFlag.Green;
            existingFlag.Blue = updatedFlag.Blue;
            existingFlag.Gold = updatedFlag.Gold;
            existingFlag.White = updatedFlag.White;
            existingFlag.Black = updatedFlag.Black;
            existingFlag.Orange = updatedFlag.Orange;
            existingFlag.MainHue = updatedFlag.MainHue;
            existingFlag.Circles = updatedFlag.Circles;
            existingFlag.Crosses = updatedFlag.Crosses;
            existingFlag.Saltires = updatedFlag.Saltires;
            existingFlag.Quarters = updatedFlag.Quarters;
            existingFlag.Sunstars = updatedFlag.Sunstars;
            existingFlag.Crescent = updatedFlag.Crescent;
            existingFlag.Triangle = updatedFlag.Triangle;
            existingFlag.Icon = updatedFlag.Icon;
            existingFlag.Animate = updatedFlag.Animate;
            existingFlag.Text = updatedFlag.Text;
            existingFlag.TopLeft = updatedFlag.TopLeft;
            existingFlag.BotRight = updatedFlag.BotRight;

            await flagsDbContext.SaveChangesAsync();

            return Ok(existingFlag);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteFlag([FromRoute] Guid id)
        {
            var existingFlag = await flagsDbContext.Flags.FindAsync(id);

            if (existingFlag == null)
            {
                return NotFound();
            }

            flagsDbContext.Flags.Remove(existingFlag);
            await flagsDbContext.SaveChangesAsync();

            return Ok();
        }
    } 
}
