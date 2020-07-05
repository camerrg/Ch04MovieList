using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketingSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TicketingSystem.Migrations
{
    [DbContext(typeof(TicketContext))]
    partial class TicketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TicketingSystem.Models.Sprint", b =>
            {
                b.Property<string>("SprintId");

                b.Property<string>("Name");

                b.HasKey("SprintId");

                b.ToTable("Sprints");

                b.HasData(
                    new
                    {
                        SprintId = "1a",
                        Name = "1A"
                    },
                    new
                    {
                        SprintId = "2a",
                        Name = "2A"
                    },
                    new
                    {
                        SprintId = "3a",
                        Name = "3A"
                    },
                    new
                    {
                        SprintId = "4a",
                        Name = "4A"
                    });
            });

            modelBuilder.Entity("TicketingSystem.Models.Status", b =>
            {
                b.Property<string>("StatusId");

                b.Property<string>("Name");

                b.HasKey("StatusId");

                b.ToTable("Statuses");

                b.HasData(
                    new
                    {
                        StatusId = "to do",
                        Name = "To Do"
                    },
                    new
                    {
                        StatusId = "in progress",
                        Name = "In Progress"
                    },
                    new
                    {
                        StatusId = "quality assurance",
                        Name = "Quality Assurance"
                    },
                    new
                    {
                        StatusId = "done",
                        Name = "Done"
                    });
            });

            modelBuilder.Entity("TicketingSystem.Models.Ticket", b =>
            {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>( "Name")
                    .IsRequired();

                b.Property<string>("SprintId")
                    .IsRequired();

                b.Property<string>("Description")
                    .IsRequired();

                b.Property<DateTime?>("DueDate")
                    .IsRequired();

                b.Property<string>("StatusId");

                b.HasKey("Id");

                b.HasIndex("SprintId");

                b.HasIndex("StatusId");

                b.ToTable("Tickets");
            });

            modelBuilder.Entity("TicketingSystem.Models.Ticket", b =>
            {
                b.HasOne("TicketingSystem.Models.Sprint", "Sprint")
                    .WithMany()
                    .HasForeignKey("SprintId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("TicketingSystem.Models.Status", "Status")
                    .WithMany()
                    .HasForeignKey("StatusId");
            });
#pragma warning restore 612, 618
        }
    }
}
