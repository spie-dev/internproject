using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Profiles.Business;

namespace WebApplication.Models.Profile
{
    public class ProfileModel
    {

        public ProfileModel(int ID)
        {
            ProfileCollection collection = new ProfileCollection();

            Profiles.Business.Profile userProfile = collection.GetProfile(ID);

            FullName = userProfile.FirstName + " " + userProfile.LastName;
            SPIERole = userProfile.SPIERole;
            Company = userProfile.Company;
            JobTitle = userProfile.JobTitle;
            PictureFileName = userProfile.PictureFileName;

        }


        public string FullName;
        public string SPIERole;
        public string Company;
        public string JobTitle;
        public string PictureFileName;
    }
}