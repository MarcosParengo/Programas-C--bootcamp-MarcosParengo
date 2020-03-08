namespace Casoides
{
    public class Puerta
    {
        protected string color;

        public Puerta (string color)
        {
            this.color = color;
        }

        public string getcolor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }
    }
}