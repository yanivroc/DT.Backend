using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using DT.Application.Interfaces;

namespace DT.Api.Controllers;

[Authorize]
[ApiController]
public abstract class CrudControllerBase<TEntity, TDto, TCreateDto, TUpdateDto> : ControllerBase
    where TEntity : class
    where TDto : class
    where TCreateDto : class
    where TUpdateDto : class
{
    protected readonly IGenericRepository<TEntity> _repo;
    protected readonly IMapper _mapper;

    protected CrudControllerBase(IGenericRepository<TEntity> repo, IMapper mapper)
    {
        _repo = repo; _mapper = mapper;
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<TDto>>> GetAll(CancellationToken ct)
        => Ok(_mapper.Map<IEnumerable<TDto>>(await _repo.GetAllAsync(ct)));

    [HttpGet("{id}")]
    public virtual async Task<ActionResult<TDto>> GetById(string id, CancellationToken ct)
    {
        var entity = await _repo.GetByIdAsync(ParseId(id), ct);
        return entity is null ? NotFound() : Ok(_mapper.Map<TDto>(entity));
    }

    [HttpPost]
    public virtual async Task<ActionResult<TDto>> Create([FromBody] TCreateDto dto, CancellationToken ct)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repo.AddAsync(entity, ct);
        return Ok(_mapper.Map<TDto>(entity));
    }

    [HttpPut("{id}")]
    public virtual async Task<ActionResult<TDto>> Update(string id, [FromBody] TUpdateDto dto, CancellationToken ct)
    {
        var entity = await _repo.GetByIdAsync(ParseId(id), ct);
        if (entity is null) return NotFound();
        _mapper.Map(dto, entity);
        await _repo.UpdateAsync(entity, ct);
        return Ok(_mapper.Map<TDto>(entity));
    }

    [HttpDelete("{id}")]
    public virtual async Task<IActionResult> Delete(string id, CancellationToken ct)
    {
        var ok = await _repo.DeleteAsync(ParseId(id), ct);
        return ok ? NoContent() : NotFound();
    }

    protected virtual object ParseId(string id) =>
        int.TryParse(id, out var i) ? i : (object)id;
}
