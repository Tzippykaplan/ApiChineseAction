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
        public async Task<LotteryTicket> createTicket(LotteryTicket lotteryTicket)
        {
            return await _raffleReposetory.createTicket(lotteryTicket);
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
