using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.Assignment6
{
    /// <summary>
    /// Abstracts describe a contract but does not provide a full implementation of the contract.
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    abstract class Vehicle : IVehicle
    {
        /*** fields section***/
        //note: in almost all programming languages, you would typically pair a field with a property
        //this is not a requirement in C# because it offers auto-property
        private string _brand;
        private string _model;
        private int _numberOfWheels;

        /***constructors section***/
        ///<summary>
        ///Default constructor
        /// </summary>
        public Vehicle()
        {

        }
        ///<summary>
        ///Constructor that takes three parameters: brand, model, numberOfWheels
        ///</summary>
        /// <param name="brand">string input for brand name</param>
        /// <param name="model">Integer input for model name</param>
        /// <param name="numberOfWheels">Integer input for number of wheels</param>
        public Vehicle(string brand, string model, int numberOfWheels)
        {
            Brand = brand;
            Model = model;
            NumberOfWheels = numberOfWheels;
        }

        /*** properties section***/
        /// <summary>
        /// Retrieve/store brand information
        /// </summary>
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        ///<summary>
        ///retrieve/store model information
        ///</summary>
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        ///<summary>
        ///Retrieve/store number of wheels information
        ///</summary>
        public int NumberOfWheels
        {
            get { return _numberOfWheels; }
            set { _numberOfWheels = value; }
        }

        /*** methods section ***/
        ///<summary>
        ///Prints the Brand, Model, and Number of Wheels information
        ///</summary>
        public virtual void GetInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        }
    }
}
