namespace GeekShopping.MessageBus
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMassage message, string queueName);
    }
}