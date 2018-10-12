namespace F1H.Classes
{
    public class CountryLoad
    {
        string rusName;
        int linkImage;

        public CountryLoad(string rusName, int linkImage)
        {
            this.rusName = rusName;
            this.LinkImage = linkImage;
        }

        public string RusName { get => rusName; set => rusName = value; }
        public int LinkImage { get => linkImage; set => linkImage = value; }
    }
}
