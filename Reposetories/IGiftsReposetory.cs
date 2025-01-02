﻿using Entities;

namespace Repository
{
    public interface IGiftsReposetory
    {
        Task<Gift> createGift(Gift gift);
        Task deleteGift(int id);
        Task<Gift> getById(int id);
        Task<List<Gift>> getGifts();
        Task<Gift> updateGift(int id, Gift giftToUpdate);
    }
}