using CartopiaWeb.Interfaces;

namespace CartopiaWeb.Repositories
{
    public class PhotoConverterRepository : IPhotoConverter
    {
        private readonly IWebHostEnvironment _env;

        public PhotoConverterRepository(IWebHostEnvironment env)
        {
            _env = env;
        }

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

        public byte[]? GetPhotoBytesFromFile(string fileName)
        {
            var photoPath = Path.Combine(_env.WebRootPath, "img", fileName);
            return File.ReadAllBytes(photoPath);
        }
    }
}
