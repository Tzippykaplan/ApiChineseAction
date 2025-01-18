using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reposetories
{

    public class DonorsReposetory : IDonorsReposetory
    {
        static int Identity = 1;
        static List<Donor> donors = [new Donor() { Id = Identity++, FirstName = "ari", LastName = "chon", Email="aari@gmail.com"},
            new Donor() { Id = Identity++, FirstName = "mmm", LastName = "gg", Email = "gg@gmail.com" }];
        public async Task<List<Donor>> getDonors()
        {
            return donors; ;



        }
        public async Task<Donor> getById(int id)
        {

            return donors.FirstOrDefault<Donor>(currenDonor => currenDonor.Id == id);


        }
        public async Task<Donor> createDonor(Donor Donor)
        {
            Donor.Id = Identity++;
            donors.Add(Donor);
            return (Donor);
        }

        public async Task<Donor> updateDonor(int id, Donor donorToUpdate)
        {
            Donor? donor = donors.Find(currenDonor => currenDonor.Id == id);

            if (donor == null)
            {
                return null;
            }
            donor.FirstName = donorToUpdate.FirstName;
            donor.LastName = donorToUpdate.LastName;
            donor.Email = donorToUpdate.Email;
            return (donor);

        }
        public async Task<Boolean> deleteDonor(int id)
        {
          
            if (GiftsReposetory.gifts.FirstOrDefault<Gift>(gift => gift.donorId == id) == null) { 
                donors.RemoveAll(currenDonor =>currenDonor.Id == id);
            return true;
            }
            else
                return false;


        }

    }

}

