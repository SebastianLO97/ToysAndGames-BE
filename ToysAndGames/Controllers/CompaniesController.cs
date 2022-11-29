using AutoMapper;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ToysAndGames.DTOs;

namespace ToysAndGames.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompaniesController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;

        public CompaniesController(ICompanyService companyService, IMapper mapper)
        {
            _companyService = companyService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CompanyDTO>> GetProducts()
        {
            return Ok(_mapper.Map<IEnumerable<CompanyDTO>>(_companyService.GetCompanies()));
        }
    }
}
