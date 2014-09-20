namespace practise_sep_20
{
    public class Animal
    {
        public string type { get; set; }
        public int legs { get; set; }
        public int Eyes { get; set; }
        public int Weight { get; set; }
        public void Walk()
        {
        }

        public void Sleep()
        {
            
        }

        public virtual string MakeNoice()
        {
            return "I am animal ";

        }


    }
}