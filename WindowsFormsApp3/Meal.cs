namespace WindowsFormsApp3
{
    public class Meal
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Name}  -  {Price}$";
        }
    }
}