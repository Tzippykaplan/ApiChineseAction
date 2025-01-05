using Entities;

namespace Reposetories
{
    public interface IRaffleReposetory
    {
        Task<LotteryTicket> createTicket(LotteryTicket lotteryTicket);
        Task<List<RaffleResponse>> GetRaffleResponse();
        Task<LotteryTicket> getTicketById(int id);
    }
}