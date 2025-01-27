using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Reposetories
{
    public class RaffleReposetory : IRaffleReposetory
    {
        public static DateTime dateOfRaffle;
        static int Identity = 1;
        static public  List<LotteryTicket> raffleTickets = [];
        public async Task<List<LotteryTicket>> createTicket(List<LotteryTicket> lotteryTickets)
        {
            lotteryTickets.ForEach(lotteryTicket =>
            {
                lotteryTicket.Id = Identity++;
                raffleTickets.Add(lotteryTicket);
               
            });
            return lotteryTickets;
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
                currentTicket => currentTicket.GiftId == curretGift.Id);
                if(currentTickets.Count() != 0){
              LotteryTicket raffleWinner = currentTickets[random.Next(currentTickets.Count)];
                User user = users.FirstOrDefault(user => user.Id == raffleWinner.UserId);
                winersTickets.Add(new RaffleResponse() { User = user, Gift = curretGift });}
                else
                {
                    winersTickets.Add(new RaffleResponse() { User = null, Gift = curretGift });
                }
            });
            return winersTickets;
        }
        public async Task<DateTime> getDateOfRaffle()
        {
            return  dateOfRaffle;
        }
        public async Task<DateTime> setDateOfRaffle(DateTime dataToSet)
        {
            dateOfRaffle = dataToSet;
            return dataToSet;
        }
    }
}
