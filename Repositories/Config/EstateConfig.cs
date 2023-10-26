using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class EstateConfig : IEntityTypeConfiguration<Estate>
    {
        public void Configure(EntityTypeBuilder<Estate> builder)
        {

            builder.HasKey(e => e.EstateId);
            builder.Property(e => e.EstateName).IsRequired();
            builder.Property(e => e.Price).IsRequired();
            builder.HasData(
                new Estate() { EstateId = 1, CategoryId = 1, Address = "Filiz Sk.No:72/1 Bayrampaşa", RoomNumber = 3, EstateName = "Daire", ImageUrl = "/images/1.jpg", Price = 1700000, Showcase = true },
                new Estate() { EstateId = 2, CategoryId = 1, Address = "Nur Sk.No:25/3 Bayrampaşa", RoomNumber = 2, EstateName = "Daire", ImageUrl = "/images/2.jpg", Price = 2500000, Showcase = true },
                new Estate() { EstateId = 3, CategoryId = 1, Address = "Kanarya Sk.No:35/1 Bayrampaşa", RoomNumber = 4, EstateName = "Müstakil Ev", ImageUrl = "/images/3.jpg", Price = 1700000, Showcase = true },
                new Estate() { EstateId = 4, CategoryId = 2, Address = "Petek Sk.No:15/4 Bayrampaşa", RoomNumber = 3, EstateName = "Daire", ImageUrl = "/images/4.jpg", Price = 10000, Showcase = false },
                new Estate() { EstateId = 5, CategoryId = 3, Address = "Sert Sk.No:11/2 Bayrampaşa", RoomNumber = 3, EstateName = "Daire", ImageUrl = "/images/5.jpg", Price = 800, Showcase = false }
            );
        }
    }
}
