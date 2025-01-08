using Entities;
using Reposetories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RaffleService : IRaffleService
    {
        IRaffleReposetory _raffleReposetory;
        public RaffleService(IRaffleReposetory raffleReposetory)
        {
            _raffleReposetory = raffleReposetory;
        }
        public async Task<List<LotteryTicket>> createTicket(List<LotteryTicket> lotteryTickets)
        {
            return await _raffleReposetory.createTicket(lotteryTickets);
        }
        public async Task<List<RaffleResponse>> GetRaffleResponse()
        {
            return await _raffleReposetory.GetRaffleResponse();
        }
       public async Task<LotteryTicket> getTicketById(int id)
        {
            return await _raffleReposetory.getTicketById(id);
        }
    }
}
