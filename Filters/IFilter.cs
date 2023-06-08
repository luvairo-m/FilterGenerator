namespace FilterGenerator.Filters
{
    public interface IFilter
    {
        public Image GetFilteredImage(Image image);
    }
}