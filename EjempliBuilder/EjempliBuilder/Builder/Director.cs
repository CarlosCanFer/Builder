using EjempliBuilder.Interfaces;

namespace EjempliBuilder
{
    public class Director
    {

        private IBuilder _builder;
        private IMotor _Tipo;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void CarDates()
        {
            this._builder.setAsientos();
            this._builder.setMotor(_Tipo);
            this._builder.setComputadoraViaje();
            this._builder.setGPS();
        }

        public void ManualDates()
        {
            this._builder.setAsientos();
            this._builder.setMotor(_Tipo);
            this._builder.setComputadoraViaje();
            this._builder.setGPS();
        }
    }
}
