using CartopiaWeb.Interfaces;

namespace CartopiaWeb.Repositories
{
    public class PhotoConverterRepository : IPhotoConverter
    {
        public byte[]? GetPhotoBytes(IFormFile photo)
        {
            byte[] photoBytes = null;

            if (photo != null && photo.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    photo.CopyTo(memoryStream);
                    photoBytes =  memoryStream.ToArray();
                }
            }

            return photoBytes;
        }
    }
}
