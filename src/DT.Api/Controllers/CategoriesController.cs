using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/categories")]
public class CategoriesController : CrudControllerBase<Categories, CategoriesDto, CreateCategoriesDto, UpdateCategoriesDto>
{
    public CategoriesController(IGenericRepository<Categories> repo, IMapper mapper) : base(repo, mapper) { }
}
