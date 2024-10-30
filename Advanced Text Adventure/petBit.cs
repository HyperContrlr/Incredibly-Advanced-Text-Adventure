namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public static petBit bitOne = new petBit("Byte", 10, 1, 1, 10, 5, 1);
        public static petBit bitTwo = new petBit("Michael", 3, 1, 1, 5, 1, 1);
        public static petBit bitThree = new petBit("BitByte", 5, 1, 1, 20, 10, 1);
        public class petBit
        {
            public string name;

            public int neededLight;
            public int minimumLight;
            public int possessedLight;

            public float healthiness;
            public float happiness;
            public float loyalty;

            public petBit(string name, int neededLight, int minimumLight, int possessedLight, float healthiness, float happiness, float loyalty)
            {
                this.name = name;
                this.neededLight = neededLight;
                this.minimumLight = minimumLight;
                this.possessedLight = possessedLight;
                this.healthiness = healthiness;
                this.happiness = happiness;
                this.loyalty = loyalty;
            }
        }
    }
}
