namespace Advanced_Text_Adventure
{
    public class Location
    {
        public static Location home = new Location("Home", "Where you feed and nurture your bit.");
        public static Location store = new Location("Store", "The Electronics store, where you get all the stuff you need for taking care of your bit");
        public static Location outside = new Location("Outside", "Where your bit can touch grass");

        public string name;
        public string description;

        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
