using Microsoft.EntityFrameworkCore;
using Vesper_HomeWork.Models;

namespace Vesper_HomeWork.DAL
{
    public class DataContextVesper:DbContext
    {
        public DataContextVesper(DbContextOptions<DataContextVesper> options) : base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Service> Services { get; set; }    
        public DbSet<SocialMedia> SocialMedias { get; set; }    
    }
}
