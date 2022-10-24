using MassTransit;
using PaiementManagementApi.Contexts;
using PaiementModels;
using SharedModels.RabbitMqModel;

namespace PaiementManagementApi.Consumers
{
    public class AbonnementCreatedConsumer : IConsumer<AbonnementCreated>
    {
        private readonly ApplicationDBContext _dBContext;


        public AbonnementCreatedConsumer(ApplicationDBContext dBContext)
        {
            _dBContext = dBContext ?? throw new ArgumentNullException(nameof(dBContext));
        }
        public async Task Consume(ConsumeContext<AbonnementCreated> context)
        {
            var newProduct = new Abonnement
            {
                ID = context.Message.ID,
                AbonnementName = context.Message.AbonnementName
            };
            _dBContext.Add(newProduct);
            await _dBContext.SaveChangesAsync();
        }
    }
}
