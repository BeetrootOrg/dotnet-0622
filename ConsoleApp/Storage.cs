using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Storage
    {
        private ArrayList _apples = new ArrayList();
        public ArrayList AppleStorage
        {
            get { return _apples; }
            set { _apples = value; }

        }
        private ArrayList _vegetables = new ArrayList();
        public ArrayList VegetableStorage
        {
            get { return _vegetables; }
            set { _vegetables = value; }
        }

         private ArrayList _alcohol = new ArrayList();
        public ArrayList AlcoholStorage
        {
            get { return _alcohol; }
            set { _alcohol = value; }
        }
        private ArrayList _nonalcohol = new ArrayList();
        public ArrayList NonAlcoholStorage
        {
            get { return _nonalcohol; }
            set { _nonalcohol = value; }
        }
        private ArrayList _bakery = new ArrayList();
        public ArrayList BakeryStorage
        {
            get { return _bakery; }
            set { _bakery = value; }
        }

    }
}
