using WebShopFresh.Services.Interface;

namespace WebShopFresh.Services.Implementation
{
    public class QueueProcessor : BackgroundService
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public QueueProcessor(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                using (var scope = _scopeFactory.CreateScope())
                {
                    var commonService = scope.ServiceProvider.GetRequiredService<ICommonService>();
                    await commonService.DeactivateAllExpiredSessions();

                }

                await Task.Delay(2000, stoppingToken);
            }
        }
    }
}