using Aspire.ResourceService.Proto.V1;
using Grpc.Core;

namespace EficazFramework.Hosting.Services;

public class DashboardService : Aspire.ResourceService.Proto.V1.DashboardService.DashboardServiceBase
{
    public override async Task<ApplicationInformationResponse> GetApplicationInformation(ApplicationInformationRequest request, ServerCallContext context)
    {
        return await Task.FromResult(new ApplicationInformationResponse()
        {
            ApplicationName = "Servidor de EficazFramework.Hosting"
        });
    }

    public override async Task WatchResources(WatchResourcesRequest request, IServerStreamWriter<WatchResourcesUpdate> responseStream, ServerCallContext context)
    {
        while (!context.CancellationToken.IsCancellationRequested)
        {
            try
            {
                await responseStream.WriteAsync(new WatchResourcesUpdate
                {
                    InitialData = new InitialResourceData()
                    {
                        Resources =
                        {
                            new Resource()
                            {
                                DisplayName = "Sample Resource 1",
                                Name = "Resource1",
                                State = ApplicationModel.KnownResourceStates.Running,
                                StateStyle = ApplicationModel.KnownResourceStateStyles.Success,
                                ResourceType = ApplicationModel.KnownResourceTypes.Service,
                                Uid = "1",
                                CreatedAt = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.UtcNow)
                            },
                            new Resource()
                            {
                                DisplayName = "Sample Resource 2",
                                Name = "Resource2",
                                State = ApplicationModel.KnownResourceStates.Finished,
                                StateStyle = ApplicationModel.KnownResourceStateStyles.Info,
                                ResourceType = ApplicationModel.KnownResourceTypes.Executable,
                                Uid = "1",
                                CreatedAt = Google.Protobuf.WellKnownTypes.Timestamp.FromDateTime(DateTime.UtcNow)
                            }

                        }
                    },
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        await Task.Delay(5000);

        await responseStream.WriteAsync(new WatchResourcesUpdate
        {
            InitialData = new InitialResourceData() { }
        });
    }
}
