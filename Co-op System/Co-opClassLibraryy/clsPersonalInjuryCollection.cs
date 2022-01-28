using System.Collections.Generic;

namespace Co_opClassLibraryy
{
    public class clsPersonalInjuryCollection
    {
        public clsPersonalInjuryCollection()
        {
            //create an instance of the personal injury class to store a type of injury
            clsPersonalInjury APersonalInjury = new clsPersonalInjury();
            APersonalInjury.TypeOfInjury = "Head";
            mAllPersonalInjuries.Add(APersonalInjury);
            APersonalInjury = new clsPersonalInjury();
            APersonalInjury.TypeOfInjury = "Orthopaedic";
            mAllPersonalInjuries.Add(APersonalInjury);
        }
        private List<clsPersonalInjury> mAllPersonalInjuries = new List<clsPersonalInjury>();
        public int Count
        {
            get
            {
                return mAllPersonalInjuries.Count;
            }
            set
            {

            }
        }

        public List<clsPersonalInjury> AllPersonalInjuries
        {
            get
            {
                return mAllPersonalInjuries;
            }
            set
            {
                mAllPersonalInjuries = value;
            }
        }
    }
}