using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// truck extends the Vehicle class
    /// </summary>
    internal class Truck : Vehicle
    {
        /*** fields section ***/
        private double _sizeoftruckBed;

        /*** constructors section ***/
        ///<summary>
        ///Constructor that takes 4 parameters: truckBrand, truckModel, truckNumberOfWheels, and sizeOfTruckBed
        ///it reuses the base class (Vehicle)'s constructor that takes 3 parameters: brand, model, numberOfWheels
        /// </summary>
        /// <param name ="truckBrand"></param>
        /// <param name ="truckModel"></param>
        /// <param name ="truckNumberOfWheels"></param>
        /// <param name="sizeOfTruckBed"></param>
        public Truck(string truckBrand, string truckModel, int truckNumberOfWheels, 
        double sizeOfTruckBed) : base(truckBrand, truckModel, truckNumberOfWheels)
        {
            SizeOfTruckBed = sizeOfTruckBed;
        }

        /*** properties section ***/
        public double SizeOfTruckBed
        {
            get { return _sizeoftruckBed; }
            set { _sizeoftruckBed = value; }
        }
        /*** methods section ***/
        ///<summary>
        ///overrides the base Vehicle's definition for GetInfo() 
        ///calls the base  Vehicle GetInfo() but adds on to it.
        /// </summary>
        public override void GetInfo()
        {
            Console.WriteLine($"I'm a {nameof(Truck)}.");
            base.GetInfo();
            Console.WriteLine($"I also have a {SizeOfTruckBed} ft truck bed");
        }
    }
    
}

