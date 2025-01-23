using Entities;
using System.ComponentModel;

namespace Repository
{
    public class GiftsReposetory : IGiftsReposetory
    {
        static int Identity = 1;
        public static List<Gift> gifts = [new Gift() { Id = Identity++, Name = "Jeep trip", Description = "fun", imgUrl = "Halfofallincome.jpeg", donorId =1 }
        ,new Gift() { Id = Identity++, Name = "car", Description = "big & nice", imgUrl = "Jeep.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "bbb", Description = "big & nice", imgUrl = "bike.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "dd", Description = "Flight for two to Austria", imgUrl = "2.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "bbb", Description = "big & nice", imgUrl = "bike.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "dd", Description = "Flight for two to Austria", imgUrl = "2.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "bbb", Description = "big & nice", imgUrl = "bike.jpeg", donorId = 0 },
            new Gift() { Id = Identity++, Name = "dd", Description = "Flight for two to Austria", imgUrl = "2.jpeg", donorId = 0 },
        ];
        public async Task<List<Gift>> getGifts()
        {
            return gifts; ;



        }
        public async Task<Gift> getById(int id)
        {

            return gifts.FirstOrDefault<Gift>(currenGift => currenGift.Id == id);


        }
        public async Task<Gift> createGift(Gift gift)
        {
            gift.Id = Identity++;
            gifts.Add(gift);
            return (gift);
        }

        public async Task<Gift> updateGift(int id, Gift giftToUpdate)
        {
            Gift? gift = gifts.Find(currenGift => currenGift.Id == id);
            
            if (gift == null)
            {
                return null;
            }
            gift.Price = giftToUpdate.Price;
            gift.Description = giftToUpdate.Description;
            gift.donorId = giftToUpdate.donorId;
            gift.Name= giftToUpdate.Name;
            gift.imgUrl = giftToUpdate.imgUrl;
            return (gift);

        }
        public async Task deleteGift(int id)
        {

            gifts.RemoveAll(currenGift => currenGift.Id == id);


        }
        public async Task<Boolean> isUnique(Gift gift)
        {
            Gift? foundGift = gifts.FirstOrDefault(currentGift => currentGift.Id != gift.Id && currentGift.Name == gift.Name);
            return foundGift!=null ? false : true;

        }

    }
}
