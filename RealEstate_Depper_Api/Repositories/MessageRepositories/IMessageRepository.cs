using RealEstate_Depper_Api.Dtos.MessageDtos;

namespace RealEstate_Depper_Api.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInBoxMessageDto>> GetInBoxLast3MessageListByReceiver(int id);
    }
}
