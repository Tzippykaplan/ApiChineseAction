using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class GiftsService : IGiftsService
    {
        IGiftsReposetory _giftsReposetory;
        public GiftsService(IGiftsReposetory _giftsReposetory)
        {
            this._giftsReposetory = _giftsReposetory;
        }
        public async Task<List<Gift>> getGifts()
        {
            return await _giftsReposetory.getGifts();

        }
        public async Task<Gift> getById(int id)
        {

            return await _giftsReposetory.getById(id);


        }
        public async Task<Gift> createGift(Gift gift)
        {
            return await _giftsReposetory.createGift(gift);
        }
        public async Task<Gift> updateGift(int id, Gift giftToUpdate)
        {
            return await _giftsReposetory.updateGift(id, giftToUpdate);

        }
        public async Task deleteGift(int id)
        {

            _giftsReposetory.deleteGift(id);


        }
        public async Task<Boolean> isUnique(Gift gift)
        {

           return await  _giftsReposetory.isUnique(gift);


        }

    }
}
