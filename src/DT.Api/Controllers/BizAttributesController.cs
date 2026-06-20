using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/bizattributes")]
public class BizAttributesController : CrudControllerBase<BizAttributes, BizAttributesDto, CreateBizAttributesDto, UpdateBizAttributesDto>
{
    public BizAttributesController(IGenericRepository<BizAttributes> repo, IMapper mapper) : base(repo, mapper) { }
}
