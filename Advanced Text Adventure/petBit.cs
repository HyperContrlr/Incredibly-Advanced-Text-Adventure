using System.Net;
using System.Text.Json.Serialization;

namespace Advanced_Text_Adventure
{
    internal partial class Program
    {
        public static petBit genericBit = new("Basic", 1, 1, 1, 1, 1, 1);
        public static petBit bitOne = new("Byte", 10, 1, 1, 10, 5, 1);
        public static petBit bitTwo = new("Michael", 3, 1, 1, 5, 1, 1);
        public static petBit bitThree = new("Bitbyte", 5, 1, 1, 20, 10, 1);
        public class petBit
        {
            public string name;

            public int neededLight;
            protected int minimumLight;
            public int possessedLight;

            public float healthiness;
            public float happiness;
            protected float loyalty;

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
        public abstract class EvilBit : petBit
        {
            protected int amountOfEvilness = 10;
            protected int amountOfEnergies = 10;
            protected string worshippedDemon = "Polaris";
            protected EvilBit(string name, int neededLight, int minimumLight, int possessedLight, float healthiness, float happiness, float loyalty) : base(name, neededLight, minimumLight, possessedLight, healthiness, happiness, loyalty)
            {
            }
        }
    }
}
