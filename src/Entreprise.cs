namespace Carfleet
{
    public class Entreprise
    {
        #region private attributes
        private List<Vehicule> _vehicule = new List<Vehicule>()
        private List<Driver> _driver = new List<Driver>()
        private List<Truck> _truck = new List<Truck>()
        private List<TruckDriver> _truckdriver = new List<TruckDriver>()
        #endregion private attributes
        private Vehicule VehiculeByChassisNumber(string chassisNumber)
        {
            foreach (Truck truck in _truck)
            {
                if (truck.chassisNumber == chassisNumber)
                {
                    return truck;
                }
            }
            throw new VehicleNotFoundException();
        }

        private Driver GetDriverByEmailaddress(string driverEmailAddress)
        {
            foreach (Truckdriver truckdriver in _truckdriver)
            {
                if (truckdriver.emailaddress == driverEmailAddress)
                {
                    return truckdriver;
                }
            }
            throw new DriverNotFoundException();
        }
        public string getDriverByEmailaddress { get => emailaddress}


        #region public methods

        public function assignVehiculeToDriver(string chassisNumber, string driverEmailAddress) : void
        {
            Driver driver = this.getDriverByEmailaddress(driverEmailAddress);
    }


    #endregion public methods

    #region private methods
    #endregion private methods

    #region nesteded class
    public class EnterpriseException : Exception { }
    public class VehicleNotFoundException : EnterpriseException { }
    public class DriverNotFoundException : EnterpriseException { }
    #endregion nesteded class
}
}
