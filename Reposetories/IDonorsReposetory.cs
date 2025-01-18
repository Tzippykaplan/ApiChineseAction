using Entities;

namespace Reposetories
{
    public interface IDonorsReposetory
    {
        Task<Donor> createDonor(Donor Donor);
        Task<Boolean> deleteDonor(int id);
        Task<Donor> getById(int id);
        Task<List<Donor>> getDonors();
        Task<Donor> updateDonor(int id, Donor donorToUpdate);
    }
}