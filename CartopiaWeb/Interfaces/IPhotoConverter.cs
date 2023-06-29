namespace CartopiaWeb.Interfaces
{
    public interface IPhotoConverter
    {
        public byte[] GetPhotoBytes(IFormFile photo);

    }
}
