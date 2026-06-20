using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/biztypes")]
public class BizTypesController : CrudControllerBase<BizTypes, BizTypesDto, CreateBizTypesDto, UpdateBizTypesDto>
{
    public BizTypesController(IGenericRepository<BizTypes> repo, IMapper mapper) : base(repo, mapper) { }
}
