using Entities;

namespace Reposetories
{
    public interface IRaffleReposetory
    {
        Task<List<LotteryTicket>> createTicket(List<LotteryTicket> lotteryTicket);
        Task<List<RaffleResponse>> GetRaffleResponse();
        Task<LotteryTicket> getTicketById(int id);
        Task<DateTime> getDateOfRaffle();
        Task<DateTime> setDateOfRaffle(DateTime dataToSet);
    }
}