namespace Carfleet
{
    public class Entreprise
    {
        #region private attributes
        private List<Vehicule> _vehicule = new List<Vehicule>()
        private List<Driver> _driver = new List<Driver>()
        #endregion private attributes
        private Vehicule VehiculeByChassisNumber(string chassisNumber)
        {
            foreach (Vehicule vehicule in _vehicule)
            {
                if (vehicule.chassisNumber == chassisNumber)
                {
                    return vehicule;
                }
            }
            throw new VehicleNotFoundException();
        }

        private Driver GetDriverByEmailaddress(string driverEmailAddress)
        {
            foreach (Driver driver in _driver)
            {
                if (driver.emailaddress == driverEmailAddress)
                {
                    return driver;
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
