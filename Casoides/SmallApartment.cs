namespace Casoides
{
    public class SmallApartment : Casa
    {
        public SmallApartment(double area,Puerta puerta) : base(50,puerta)
        {
            this.puerta = puerta;
        }
    }
}