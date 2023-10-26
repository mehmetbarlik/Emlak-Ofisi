using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole() { Name = "Kullanıcı", NormalizedName = "KULLANICI" },
                new IdentityRole() { Name = "Emlakçı", NormalizedName = "EMLAKÇI" },
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" }
            );
        }
    }
}
