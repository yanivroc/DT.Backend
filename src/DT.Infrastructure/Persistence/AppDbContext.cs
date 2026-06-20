using Microsoft.EntityFrameworkCore;
using DT.Domain.Entities;

namespace DT.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<BanIPs> BanIPs { get; set; } = null!;
    public DbSet<BizAttributes> BizAttributes { get; set; } = null!;
    public DbSet<BizCategory> BizCategory { get; set; } = null!;
    public DbSet<BizContactedPerson> BizContactedPerson { get; set; } = null!;
    public DbSet<BizPic> BizPic { get; set; } = null!;
    public DbSet<Bizs> Bizs { get; set; } = null!;
    public DbSet<BizTypes> BizTypes { get; set; } = null!;
    public DbSet<BizVideo> BizVideo { get; set; } = null!;
    public DbSet<Categories> Categories { get; set; } = null!;
    public DbSet<ContactedPersons> ContactedPersons { get; set; } = null!;
    public DbSet<Contacts> Contacts { get; set; } = null!;
    public DbSet<Countries> Countries { get; set; } = null!;
    public DbSet<ErrorLog> ErrorLog { get; set; } = null!;
    public DbSet<GeneralSettings> GeneralSettings { get; set; } = null!;
    public DbSet<MemberAccounts> MemberAccounts { get; set; } = null!;
    public DbSet<MemberAPI> MemberAPI { get; set; } = null!;
    public DbSet<MemberContactedPerson> MemberContactedPerson { get; set; } = null!;
    public DbSet<MemberInvoices> MemberInvoices { get; set; } = null!;
    public DbSet<MemberOrders> MemberOrders { get; set; } = null!;
    public DbSet<MemberPoints> MemberPoints { get; set; } = null!;
    public DbSet<MemberProofs> MemberProofs { get; set; } = null!;
    public DbSet<MemberRedeems> MemberRedeems { get; set; } = null!;
    public DbSet<MemberReferals> MemberReferals { get; set; } = null!;
    public DbSet<MemberRewards> MemberRewards { get; set; } = null!;
    public DbSet<Members> Members { get; set; } = null!;
    public DbSet<Pics> Pics { get; set; } = null!;
    public DbSet<Regions> Regions { get; set; } = null!;
    public DbSet<States> States { get; set; } = null!;
    public DbSet<DT.Domain.Entities.TimeZone> TimeZone { get; set; } = null!;
    public DbSet<UserAgents> UserAgents { get; set; } = null!;
    public DbSet<Videos> Videos { get; set; } = null!;
    public DbSet<WebBuilderContactedPerson> WebBuilderContactedPerson { get; set; } = null!;
    public DbSet<WebBuilders> WebBuilders { get; set; } = null!;
    public DbSet<WebCategory> WebCategory { get; set; } = null!;
    public DbSet<WebPageBizs> WebPageBizs { get; set; } = null!;
    public DbSet<WebPages> WebPages { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<BanIPs>().HasKey(e => e.Id);
        modelBuilder.Entity<BizAttributes>().HasKey(e => e.Id);
        modelBuilder.Entity<BizCategory>().HasKey(e => new { e.Bizs_BizId, e.Categories_CategoryId });
        modelBuilder.Entity<BizContactedPerson>().HasKey(e => new { e.Bizs_BizId, e.ContactedPersons_ContactedPersonId });
        modelBuilder.Entity<BizPic>().HasKey(e => new { e.Bizs_BizId, e.Pics_PicId });
        modelBuilder.Entity<Bizs>().HasKey(e => e.BizId);
        modelBuilder.Entity<BizTypes>().HasKey(e => e.Id);
        modelBuilder.Entity<BizVideo>().HasKey(e => new { e.Bizs_BizId, e.Videos_VideoId });
        modelBuilder.Entity<Categories>().HasKey(e => e.CategoryId);
        modelBuilder.Entity<ContactedPersons>().HasKey(e => e.ContactedPersonId);
        modelBuilder.Entity<Contacts>().HasKey(e => e.Id);
        modelBuilder.Entity<Countries>().HasKey(e => e.Id);
        modelBuilder.Entity<ErrorLog>().HasKey(e => e.Id);
        modelBuilder.Entity<GeneralSettings>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberAccounts>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberAPI>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberContactedPerson>().HasKey(e => new { e.ContactedPersons_ContactedPersonId, e.Members_MemberId });
        modelBuilder.Entity<MemberInvoices>().HasKey(e => e.InvoiceId);
        modelBuilder.Entity<MemberOrders>().HasKey(e => e.OrderId);
        modelBuilder.Entity<MemberPoints>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberProofs>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberRedeems>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberReferals>().HasKey(e => e.Id);
        modelBuilder.Entity<MemberRewards>().HasKey(e => e.Id);
        modelBuilder.Entity<Members>().HasKey(e => e.MemberId);
        modelBuilder.Entity<Pics>().HasKey(e => e.PicId);
        modelBuilder.Entity<Regions>().HasKey(e => e.Id);
        modelBuilder.Entity<States>().HasKey(e => e.Id);
        modelBuilder.Entity<DT.Domain.Entities.TimeZone>().HasKey(e => e.Id);
        modelBuilder.Entity<UserAgents>().HasKey(e => e.Id);
        modelBuilder.Entity<Videos>().HasKey(e => e.VideoId);
        modelBuilder.Entity<WebBuilderContactedPerson>().HasKey(e => new { e.ContactedPersons_ContactedPersonId, e.WebBuilders_Id });
        modelBuilder.Entity<WebBuilders>().HasKey(e => e.Id);
        modelBuilder.Entity<WebCategory>().HasKey(e => new { e.Categories_CategoryId, e.WebBuilders_Id });
        modelBuilder.Entity<WebPageBizs>().HasKey(e => new { e.WebPageId, e.BizTypeId });
        modelBuilder.Entity<WebPages>().HasKey(e => e.Id);
    }
}
