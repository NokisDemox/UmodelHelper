using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmodelHelper
{
    public class UModel
    {
        //Info of umodel
        private string name;
        private string path;

        //Public variables
        public string Name { get { return name; } set { name = value; } }
        public string Path { get { return path; } set { path = value; } }



        public string SaveString()
        {
            return Name + ";" + Path;
        }



    }
}
