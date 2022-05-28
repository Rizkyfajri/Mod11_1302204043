using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11_1302204043
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance = null;
        private List<string> DataSimpan;

        private PusatDataSingleton()
        {
            this.DataSimpan = new List<string>();
        }
        
        public static PusatDataSingleton GetPusatDataSingleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PusatDataSingleton();
                }
                return _instance;
            }
        } 

        public List<string> GetSemuaData()
        {
            return null;
        }
        public void PrintSemuaData()
        {
            
        }
        public void AddSebuahData(string a)
        {

        }
        public void HapusSebuahData(int index)
        {

        }


    }
}
