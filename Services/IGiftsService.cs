using Entities;

namespace Services
{
    public interface IGiftsService
    {
        Task<Gift> createGift(Gift gift);
        Task<bool> deleteGift(int id);
        Task<Gift> getById(int id);
        Task<List<Gift>> getGifts();
        Task<Gift> updateGift(int id, Gift giftToUpdate);
        Task<Boolean> isUnique(Gift gift);
    }
}