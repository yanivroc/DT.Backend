using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/videos")]
public class VideosController : CrudControllerBase<Videos, VideosDto, CreateVideosDto, UpdateVideosDto>
{
    public VideosController(IGenericRepository<Videos> repo, IMapper mapper) : base(repo, mapper) { }
}
