namespace Carfleet
{
    public class Person
    {
        #region private attributes
        private _emailaddress = string
        #endregion private attributes

        #region public methods
        public function Person(string : emailaddress)
        {
            _emailaddress = emailaddress;
        }

        public string emailaddress { get => _emailaddress; }

        #endregion public methods

        #region private methods
        #endregion private methods
    }
}
