using EjempliBuilder.Interfaces;

namespace EjempliBuilder
{
    public class CarBuilder : IBuilder
    {
        private Car _product = new Car();       

        public CarBuilder()
        {
            this.Reset();
        }

        private void Reset()
        {
            this._product = new Car();
        }

        public void setAsientos()
        {
            this._product.Add("Asientos");
        }

        public void setComputadoraViaje()
        {
            this._product.Add("ComputadoraViaje");
        }

        public void setGPS()
        {
            this._product.Add("GPS");
        }

        public void setMotor(IMotor motor)
        {
            this._product.Add("Motor");
        }

        public Car GetProduct()
        {
            Car result = this._product;

            this.Reset();

            return result;

        }
    }
}
