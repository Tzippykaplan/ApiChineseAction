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
        static List<Donor> donors = [
                new Donor() { Id = Identity++, FirstName = "ari", LastName = "chon", Email="aari@gmail.com"},
                new Donor() { Id = Identity++, FirstName = "john", LastName = "doe", Email = "johndoe@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "jane", LastName = "doe", Email = "janedoe@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "sam", LastName = "smith", Email = "samsmith@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "emma", LastName = "stone", Email = "emmastone@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "alex", LastName = "brown", Email = "alexbrown@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "mia", LastName = "jones", Email = "miajones@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "liam", LastName = "wilson", Email = "liamwilson@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "noah", LastName = "lee", Email = "noahlee@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "sophia", LastName = "clark", Email = "sophiaclark@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "oliver", LastName = "miller", Email = "olivermiller@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "ava", LastName = "garcia", Email = "avagarcia@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "william", LastName = "martin", Email = "williammartin@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "isabella", LastName = "rodriguez", Email = "isabellarodriguez@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "james", LastName = "lopez", Email = "jameslopez@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "amelia", LastName = "hill", Email = "ameliahill@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "lucas", LastName = "green", Email = "lucasgreen@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "mia", LastName = "adams", Email = "miaadams@gmail.com" },
                new Donor() { Id = Identity++, FirstName = "elijah", LastName = "nelson", Email = "elijahnelson@gmail.com" }
            ];
        public async Task<List<Donor>> getDonors()
        {
            List<Gift> gifts = GiftsReposetory.gifts;
            donors.ForEach(curretDonor =>
            {
                curretDonor.MyGiftsList = gifts.FindAll(gift => gift.donorId == curretDonor.Id);
            });
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

