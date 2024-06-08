using USRInfo.Models;

namespace USRInfo.Services
{
    public interface ITMAService
    {
        Task<Status> GetStatusByRef(string reqRef, CancellationToken cancellationToken);

        Task<USRSteps> GetUsrSteps(string id, CancellationToken cancellationToken);
    }

    public class TMAService : ITMAService
    {
        public HttpClient _httpClient { get; set; }

        public TMAService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Status> GetStatusByRef(string reqRef, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            return new Status()
            {
                id = 1,
                requestReference = Guid.NewGuid().ToString("N"),
                customerReference = "AW52871",
                timeStamp = DateTime.Now,
                requestType = "Device Pre-notification",
                status = "Success"
            };
        }

        public async Task<USRSteps> GetUsrSteps(string id, CancellationToken cancellationToken)
        {

            await Task.CompletedTask;

            return new USRSteps
            {
              stepDetails = new List<StepDetails>
                {
                    new StepDetails
                    {
                       id = Guid.NewGuid().ToString(),
                       created= DateTime.Now,
                       executed= DateTime.Now,
                       index= 0,
                       stepStatus = "Success",
                       isSupport = false,
                       description = "3.1 - Display Message",
                       requireSupportInput= false,
                       requestInfo = "{\"Message\":\"Test Message\",\"DeviceForSupplier\": false, \"OriginatorContextId\":2}",
                       responseInfo = "{\"DeviceId\":\"54-30-63-34-38-96-82-93\", \"Result\":1}",
                       ackResponseInfo = null,
                       isCancellable = false
                    }
                }
            };
        }
    }
}
