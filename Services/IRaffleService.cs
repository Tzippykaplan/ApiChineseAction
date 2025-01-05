using Entities;

namespace Services
{
    public interface IRaffleService
    {
        Task<LotteryTicket> createTicket(LotteryTicket lotteryTicket);
        Task<List<RaffleResponse>> GetRaffleResponse();
        Task<LotteryTicket> getTicketById(int id);
    }
}