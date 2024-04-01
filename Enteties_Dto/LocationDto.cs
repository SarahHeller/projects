namespace Enteties_Dto
{
    public class LocationDto
    {
        public string Book { get; set; }
        public string Parasha { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }
        public override string ToString()
        {
            return Book + " " + Parasha + " " + Chapter + " " + Verse + "\n";
        }
    }
}