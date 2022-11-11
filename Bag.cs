namespace drunkstudent
{
    public class Bag
    {
        public int PizzaPieces { get; set; }
        public int BeerBottles { get; set; }
        public int Capacity { get; set; }

        public bool AddPizza(int pieces, Bag bag)
        {
            bag.PizzaPieces += pieces;

            if ((bag.PizzaPieces * 0.2 + bag.BeerBottles*0.5) > bag.Capacity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool AddBeer(int bottles, Bag bag)
        {
            bag.BeerBottles += bottles;

            if ((bag.PizzaPieces * 0.2 + bag.BeerBottles*0.5) > bag.Capacity)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
