using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Profile_and_Singers.Data.Services;
using Profile_and_Singers.Dtos;
using Profile_and_Singers.Models;

namespace Profile_and_Singers.Controllers
{
    [Route("api/[controller]")]
    public class MusicController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IMusicServices _service;

        public MusicController(IMapper mapper,IMusicServices services)
        {
            _mapper = mapper;
            _service = services;
        }

        [HttpPost("add-music")]
        public async Task<ActionResult<MusicDto>> AddPhoto(IFormFile file)
        {
            

            var result = await _service.AddMusicAsync(file);

            if (result.Error != null) return BadRequest(result.Error.Message);

            var music = new Music
            {
                Url = result.SecureUrl.AbsoluteUri,
                PublicId = result.PublicId
            };

            

            

            if (await _service.SaveAllAsync())
            {
                return Ok(music);
            }


            return BadRequest("Problem addding photo");
        }

    }
}
