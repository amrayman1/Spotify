using CloudinaryDotNet.Actions;

namespace Profile_and_Singers.Data.Services
{
    public interface IMusicServices
    {
        
            Task<VideoUploadResult> AddMusicAsync(IFormFile file);
            Task<DeletionResult> DeleteMusicAsync(string publicId);
            Task<bool> SaveAllAsync();



    }
}
