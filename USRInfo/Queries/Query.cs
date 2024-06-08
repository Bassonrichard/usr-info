using USRInfo.Services;

namespace USRInfo.Queries
{
    public class Query
    {
        public Task GetTodosAsync(
           [Service] ITMAService service,
            string reqRef,
           CancellationToken cancellationToken)
        {
            return service.GetStatusByRef("", cancellationToken);
        }
    }
}
