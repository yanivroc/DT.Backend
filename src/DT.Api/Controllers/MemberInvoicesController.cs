using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/memberinvoices")]
public class MemberInvoicesController : CrudControllerBase<MemberInvoices, MemberInvoicesDto, CreateMemberInvoicesDto, UpdateMemberInvoicesDto>
{
    public MemberInvoicesController(IGenericRepository<MemberInvoices> repo, IMapper mapper) : base(repo, mapper) { }
}
