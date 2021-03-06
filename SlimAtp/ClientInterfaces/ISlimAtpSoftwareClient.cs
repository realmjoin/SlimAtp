using SlimAtp.Auth;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace SlimAtp
{
    public interface ISlimAtpSoftwareClient
    {
        Task<JsonElement> GetSoftwareAsync(IAzureTenant tenant, string id, ScalarRequestOptions? options = default, CancellationToken cancellationToken = default);

        IAsyncEnumerable<JsonElement> ListSoftwareAsync(IAzureTenant tenant, ListRequestOptions? options = default, CancellationToken cancellationToken = default);
    }
}