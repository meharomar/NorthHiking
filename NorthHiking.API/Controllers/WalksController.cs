using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthHiking.API.Model.Domain;
using NorthHiking.API.Model.DTO;
using NorthHiking.API.Repositories;

namespace NorthHiking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalksController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IWalkRepository walkRepository;

        public WalksController(IMapper mapper, IWalkRepository walkRepository)
        {
            this.mapper = mapper;
            this.walkRepository = walkRepository;
        }
        // Creat Walks
        //Post: /api/walks
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AddWalksRequestDto addWalksRequestDto)
        {
            var walkDomainModel = mapper.Map<Walk>(addWalksRequestDto);

            await walkRepository.CreateAsync(walkDomainModel);

            // Map domain model to DTO
            
            return Ok(mapper.Map<WalkDto>(walkDomainModel));
        }
    }
}
