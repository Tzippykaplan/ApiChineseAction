using Entities;
using Reposetories;
using Repository;

namespace Services
{
    public class DonorsService : IDonorsService
    {
        IDonorsReposetory _donorsReposetory;
        public DonorsService(IDonorsReposetory _donorsReposetory)
        {
            this._donorsReposetory = _donorsReposetory;
        }
        public async Task<List<Donor>> getDonors()
        {
            return await _donorsReposetory.getDonors();

        }
        public async Task<Donor> getById(int id)
        {

            return await _donorsReposetory.getById(id);


        }
        public async Task<Donor> createDonor(Donor donor)
        {
            return await _donorsReposetory.createDonor(donor);
        }
        public async Task<Donor> updateDonor(int id, Donor donorToUpdate)
        {
            return await _donorsReposetory.updateDonor(id, donorToUpdate);

        }
        public async Task<Boolean> deleteDonor(int id)
        {

           return await _donorsReposetory.deleteDonor(id);


        }
    }
}
