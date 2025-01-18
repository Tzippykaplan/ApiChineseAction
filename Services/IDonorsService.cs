using Entities;

namespace Services
{
    public interface IDonorsService
    {
        Task<Donor> createDonor(Donor donor);
        Task<Boolean> deleteDonor(int id);
        Task<Donor> getById(int id);
        Task<List<Donor>> getDonors();
        Task<Donor> updateDonor(int id, Donor donorToUpdate);
    }
}