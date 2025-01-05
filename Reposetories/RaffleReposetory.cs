using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetories
{
    public class RaffleReposetory : IRaffleReposetory
    {
        static int Identity = 1;
        static List<LotteryTicket> raffleTickets = [];
        public async Task<LotteryTicket> createTicket(LotteryTicket lotteryTicket)
        {
            lotteryTicket.Id = Identity++;
            raffleTickets.Add(lotteryTicket);
            return lotteryTicket;
        }
        public async Task<LotteryTicket> getTicketById(int id)
        {
           return raffleTickets.Find(raffleTicket => raffleTicket.Id == id);    
        }
        public async Task<List<RaffleResponse>> GetRaffleResponse()
        {
            Random random = new Random();
            List<Gift> gifts = GiftsReposetory.gifts;
            List<User> users = UserReposetory.users;
            List<RaffleResponse> winersTickets = [];
            gifts.ForEach(curretGift =>
            {
                List<LotteryTicket> currentTickets = raffleTickets.FindAll(
                gift => gift.Id == curretGift.Id);
                LotteryTicket raffleWinner = currentTickets[random.Next(currentTickets.Count)];
                User user = users.FirstOrDefault(user => user.Id == raffleWinner.Id);
                winersTickets.Add(new RaffleResponse() { User = user, Gift = curretGift });
            });
            return winersTickets;
        }

    }
}
