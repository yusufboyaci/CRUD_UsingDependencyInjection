using CRUD_UsingDependencyInjection.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD_UsingDependencyInjection.Models.Mapping
{
    public class DetailMap : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(50);
            builder.Property(x => x.UserName).HasMaxLength(50);
            builder.Property(x => x.Password).HasMaxLength(50);
            builder.ToSqlQuery("use WEBdb");
            builder.ToSqlQuery("Insert into Details values ('3E9310A8-5A10-4127-86E9-446A512924FF','DIVYA','DIVYA@gmail.com',1234)");
            builder.ToSqlQuery("Insert into Details values ('846CF64E-9983-4B7A-B528-125600F63A6E','maneesha','maneesha@gmail.com',5678)");
            builder.ToSqlQuery("Insert into Details values ('51B7E807-3754-496F-BD1F-72ED7435B538','Ishika','Ishika@gmail.com',8976)");
        }
    }
}
