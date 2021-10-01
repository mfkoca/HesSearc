using System;
using System.Collections.Generic;
using System.Text;

namespace HesSearch.Services
{
    public class HesModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string HesCode { get; set; }
        public DateTime EffectiveDate { get; set; }
        public bool IsRisky { get; set; }
        public List<VaccinationHistory> VaccinationHistory { get; set; }
    }

    public class VaccinationHistory
    {
        public DateTime VaccinationDate { get; set; }
        public int Dose { get; set; }
        public string VaccinationType { get; set; }
    }
}
