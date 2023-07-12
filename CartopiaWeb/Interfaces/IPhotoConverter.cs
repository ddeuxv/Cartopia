namespace CartopiaWeb.Interfaces
{
    public interface IPhotoConverter
    {
        public byte[]? GetPhotoBytes(IFormFile photo);
        public byte[]? GetPhotoBytesFromFile(string fileName);
    }
}
