using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TMT.MS.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
