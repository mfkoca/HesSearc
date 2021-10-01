using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HesSearch.Services
{
    public class HesSearhServices : IHesSearhServices
    {
       
        public HesModel GetHesCodeSeacrh(string hesCode)
        {
            List<HesModel> data = new HesSearhData().Data; // vatandaşların listesini alır
            var result = data.FirstOrDefault(c => c.HesCode == hesCode); // ilgili hes koda ist vatandaşı bulur
            return result;
        }
    }
}
