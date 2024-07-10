using Domain.LearningSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.LearningSystem.Configurations
{
    public class UserConfiguratioin : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users")
                .HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar");

            builder.Property(x => x.Surname)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasMaxLength(50)
                .HasColumnType("varchar")
                .IsRequired();

            builder.Property(x => x.Role)
                .IsRequired();

            builder.Property(x => x.PasswordSalt)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.PasswordHash)
                .HasMaxLength(200)
                .HasColumnType("varchar")
                .IsRequired();



        }
    }
}
