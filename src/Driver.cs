namespace Carfleet
{
    public class Driver : Person
    {
        #region private attributes
        private Vehicule _vehicule = null
        #endregion private attributes

        #region public methods

        public Driver(string emailaddress) : base(emailaddress) { }

        public function takeVehicule(vehicule : Vehicule) : void
        {
            if(_vehicule != null){
                throw new VehicleAlreadyAssignedException
            }
            _vehicule = vehicule;
        }
        #endregion public methods

        #region private methods
        #endregion private methods

        #region nesteded classes
        public class DriverException : Exception { }
        public class VehicleAlreadyAssignedException : DriverException { }
        #endregion nested classes
    }
}
