using System.Threading.Tasks;
using NNChallenge.Models;

namespace NNChallenge.Contracts
{
    public interface IForecastService
    {
        /// <summary>
        /// return an object with three days forecast information
        /// </summary>
        /// <param name="queryString">city to consult</param>
        /// <returns>All forecast data from this city in the next 3 days</returns>
        public Task<ResponseModel> GetForecastData(string queryString);
    }
}
