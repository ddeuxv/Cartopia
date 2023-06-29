using CartopiaWeb.Interfaces;

namespace CartopiaWeb.Repositories
{
    public class PhotoConverterRepository : IPhotoConverter
    {
        public byte[]? GetPhotoBytes(IFormFile photo)
        {
            if (photo != null && photo.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    photo.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }

            return null;
        }
    }
}
