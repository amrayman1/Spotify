using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Profile_and_Singers.Helper;

namespace Profile_and_Singers.Data.Services
{
    public class MusicService : IMusicServices
    {
        private readonly Cloudinary _cloudinary;
        private readonly AppDbContext _context;

        public MusicService(IOptions<CloudinarySettings> config, AppDbContext context)
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret);
            _cloudinary = new Cloudinary(acc);
            _context = context;
        }
        public async Task<VideoUploadResult> AddMusicAsync(IFormFile file)
        {
            var uploadResult = new VideoUploadResult();

            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new VideoUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Duration("3.0").StartOffset("2.0").Chain().AudioCodec("mp3")
                };
                uploadResult = await _cloudinary.UploadAsync(uploadParams);
            }

            return uploadResult;
        }

        public async Task<DeletionResult> DeleteMusicAsync(string publicId)
        {
            var deleteParmas = new DeletionParams(publicId);
            var result = await _cloudinary.DestroyAsync(deleteParmas);
            return result;
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
