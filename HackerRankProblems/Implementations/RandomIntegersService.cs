using System.Threading.Tasks;
using Flurl;
using Flurl.Http;


namespace HackerRankProblems.Implementations
{
    public class RandomIntegersService
    {
        public async Task<string> GetRandomIntegersAsync(int num, int min, int max, int col)
        {
            var result = await "https://www.random.org/"
                .AppendPathSegment("integers")
                .SetQueryParam("num", num)
                .SetQueryParam("min", min)
                .SetQueryParam("max", max)
                .SetQueryParam("col", col)
                .SetQueryParam("base", "10")
                .SetQueryParam("format", "plain")
                .SetQueryParam("rnd", "new")
                .GetAsync()
                .ConfigureAwait(false);

            return await result.ResponseMessage.Content
                .ReadAsStringAsync()
                .ConfigureAwait(false);         
        }
    }
}
