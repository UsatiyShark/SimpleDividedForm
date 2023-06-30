using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedFormPractics
{
    public class Controller
    {
        //AnimalPicProvider picProvider;
        Dogs dog=new Dogs();
        Foxes fox=new Foxes(); 
        public string ShowPic()
        {
            //return dog.GetAnimalPic();
            return fox.GetAnimalPic();
        }
    }
 
}
