using EjempliBuilder.Interfaces;

namespace EjempliBuilder.Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual = new Manual();
        

        public CarManualBuilder()
        {
            this.Reset();
        }
       
        private void Reset()
        {
            this._manual = new Manual();
        }

        public void setAsientos()
        {
            this._manual.Add("Asientos");
        }

        public void setComputadoraViaje()
        {
            this._manual.Add("ComputadoraViaje");
        }

        public void setGPS()
        {
            this._manual.Add("GPS");
        }

        public void setMotor(IMotor motor)
        {
            this._manual.Add("Motor");
        }

        public Manual GetProduct()
        {
            Manual result = this._manual;
            this.Reset();
            return result;
        }
    }
}
