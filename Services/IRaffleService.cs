using Entities;

namespace Services
{
    public interface IRaffleService
    {
        Task<List<LotteryTicket>> createTicket(List<LotteryTicket> lotteryTicket);
        Task<List<RaffleResponse>> GetRaffleResponse();
        Task<LotteryTicket> getTicketById(int id);
    }
}