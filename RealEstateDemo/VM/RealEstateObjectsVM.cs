using RealEstateDemo.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDemo.VM
{
    public class RealEstateObjectsVM : BaseViewModel
    {
        // класс RealEstateObjects.xaml

        public List<string> ObjectTypes { get; set; }
        public RealEstateObjectsVM()
        {

            ObjectTypes = new List<string>(new string[] { "Земля", "Квартира" , "Дом" });
        }
    }
}
