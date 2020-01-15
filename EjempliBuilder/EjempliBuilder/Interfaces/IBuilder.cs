namespace EjempliBuilder.Interfaces
{
    public interface IBuilder
    {
        void setAsientos();

        void setMotor(IMotor motor);

        void setComputadoraViaje();

        void setGPS();
    }
}
