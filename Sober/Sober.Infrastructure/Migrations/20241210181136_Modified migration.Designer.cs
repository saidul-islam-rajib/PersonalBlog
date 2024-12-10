﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sober.Infrastructure.Persistence;

#nullable disable

namespace Sober.Infrastructure.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    [Migration("20241210181136_Modified migration")]
    partial class Modifiedmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExperienceSkills", b =>
                {
                    b.Property<Guid>("EducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SkillId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExperienceId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EducationId", "SkillId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("SkillId");

                    b.ToTable("ExperienceSkills");
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.CommentAggregate.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Comments", (string)null);
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.EducationAggregate.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EducationId");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InstituteLogo")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("InstituteName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Educations", (string)null);
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.ExperienceAggregate.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyLogo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsCurrentEmployee")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFullTimeEmployee")
                        .HasColumnType("bit");

                    b.Property<string>("ShortName")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Experiences", (string)null);
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.PostAggregate.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostAbstract")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("PostTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Posts", (string)null);
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.SkillAggregate.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("SkillId");

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Skills", (string)null);
                });

            modelBuilder.Entity("Sober.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("ExperienceSkills", b =>
                {
                    b.HasOne("Sober.Domain.Aggregates.EducationAggregate.Education", null)
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sober.Domain.Aggregates.ExperienceAggregate.Experience", null)
                        .WithMany()
                        .HasForeignKey("ExperienceId");

                    b.HasOne("Sober.Domain.Aggregates.SkillAggregate.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.CommentAggregate.Comment", b =>
                {
                    b.HasOne("Sober.Domain.Aggregates.PostAggregate.Post", null)
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sober.Domain.Aggregates.PostAggregate.Post", b =>
                {
                    b.OwnsMany("Sober.Domain.Aggregates.PostAggregate.Entities.PostSection", "Sections", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("SectionId");

                            b1.Property<Guid>("PostId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("SectionDescription")
                                .IsRequired()
                                .HasMaxLength(500)
                                .HasColumnType("nvarchar(500)");

                            b1.Property<string>("SectionTitle")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.HasKey("Id", "PostId");

                            b1.HasIndex("PostId");

                            b1.ToTable("Sections", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PostId");

                            b1.OwnsMany("Sober.Domain.Aggregates.PostAggregate.Entities.PostItem", "Items", b2 =>
                                {
                                    b2.Property<Guid>("Id")
                                        .HasColumnType("uniqueidentifier")
                                        .HasColumnName("PostItemId");

                                    b2.Property<Guid>("SectionId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("PostId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("PostItemDescription")
                                        .IsRequired()
                                        .HasMaxLength(500)
                                        .HasColumnType("nvarchar(500)");

                                    b2.Property<string>("PostItemImageLink")
                                        .IsRequired()
                                        .HasColumnType("nvarchar(max)");

                                    b2.Property<string>("PostItemTitle")
                                        .IsRequired()
                                        .HasMaxLength(100)
                                        .HasColumnType("nvarchar(100)");

                                    b2.HasKey("Id", "SectionId", "PostId");

                                    b2.HasIndex("SectionId", "PostId");

                                    b2.ToTable("PostItems", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("SectionId", "PostId");
                                });

                            b1.Navigation("Items");
                        });

                    b.OwnsMany("Sober.Domain.Aggregates.PostAggregate.Entities.PostTopic", "TopicIds", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .HasColumnType("uniqueidentifier")
                                .HasColumnName("TopicId");

                            b1.Property<Guid>("PostId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("TopicTitle")
                                .IsRequired()
                                .HasMaxLength(100)
                                .HasColumnType("nvarchar(100)");

                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("Id", "PostId");

                            b1.HasIndex("PostId");

                            b1.ToTable("Topics", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("PostId");
                        });

                    b.Navigation("Sections");

                    b.Navigation("TopicIds");
                });
#pragma warning restore 612, 618
        }
    }
}
