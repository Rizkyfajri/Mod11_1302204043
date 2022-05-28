using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Dibuat oleh Fajri
namespace Mod11_1302204043
{
    public class PusatDataSingleton
    {
        private static PusatDataSingleton _instance = null;
        private List<string> DataTersimpan;

        private PusatDataSingleton()
        {
            this.DataTersimpan = new List<string>();
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
            return this.DataTersimpan;
        }
        public void PrintSemuaData()
        {
            for (int i = 0; i < DataTersimpan.Count; i++)
            {
                Console.WriteLine(DataTersimpan[i]);
            }
        }
        public void AddSebuahData(string input)
        {
            DataTersimpan.Add(input);
        }
        public void HapusSebuahData(int index)
        {
            DataTersimpan.RemoveAt(index);
        }


    }
}
