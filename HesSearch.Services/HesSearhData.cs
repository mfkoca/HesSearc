using System;
using System.Collections.Generic;
using System.Text;

namespace HesSearch.Services
{
    public class HesSearhData
    {
        public List<HesModel> Data { get; set; }
        public HesSearhData()
        {
            Data = new List<HesModel>();
            
            Data.Add(new HesModel
            {
                HesCode = "87654321",
                EffectiveDate = DateTime.Now.AddDays(100),
                IsRisky = false,
                Name = "Mehmet Fatih",
                Surname = "Koca",
                VaccinationHistory = new List<VaccinationHistory>
                {
                    new VaccinationHistory{
                      Dose =1,
                      VaccinationDate = DateTime.Now.AddDays(-50),
                      VaccinationType ="Sinovac"
                    },new VaccinationHistory{
                      Dose =2,
                      VaccinationDate = DateTime.Now.AddDays(-25),
                      VaccinationType ="Sinovac"
                    },new VaccinationHistory{
                      Dose =3,
                      VaccinationDate = DateTime.Now.AddDays(-5),
                      VaccinationType ="Sinovac"
                    },
                }
            });
            Data.Add(new HesModel
            {
                HesCode = "10987656",
                EffectiveDate = DateTime.Now.AddDays(150),
                IsRisky = false,
                Name = "Kemal",
                Surname = "Avcı",
                VaccinationHistory = new List<VaccinationHistory>
                {
                    new VaccinationHistory{
                      Dose =1,
                      VaccinationDate = DateTime.Now.AddDays(-50),
                      VaccinationType ="Biontech"
                    },new VaccinationHistory{
                      Dose =2,
                      VaccinationDate = DateTime.Now.AddDays(-25),
                      VaccinationType ="Biontech"
                    }
                }
            });
            Data.Add(new HesModel
            {
                HesCode = "1234678",
                EffectiveDate = DateTime.Now.AddDays(100),
                IsRisky = true,
                Name = "Ali",
                Surname = "Ters",
                VaccinationHistory = new List<VaccinationHistory>
                {
                    new VaccinationHistory{
                      Dose =1,
                      VaccinationDate = DateTime.Now.AddDays(-50),
                      VaccinationType ="Sinovac"
                    }
                }
            });

        }


    }
}
