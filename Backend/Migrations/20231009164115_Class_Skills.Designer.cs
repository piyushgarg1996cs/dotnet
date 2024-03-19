﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace UGHApi.Migrations
{
    [DbContext(typeof(UghContext))]
    [Migration("20231009164115_Class_Skills")]
    partial class ClassSkills
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UGHApi.Models.Membership", b =>
                {
                    b.Property<int>("MembershipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime(6)");

                    b.HasKey("MembershipID");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("UGHApi.Models.Profile", b =>
                {
                    b.Property<int>("Profile_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext");

                    b.HasKey("Profile_ID");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("UGHApi.Models.Skill", b =>
                {
                    b.Property<int>("Skill_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("SkillDescrition")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Skill_ID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("UGHModels.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CurrentMembershipMembershipID")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email_Adress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("VerificationState")
                        .HasColumnType("int");

                    b.Property<string>("VisibleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("User_Id");

                    b.HasIndex("CurrentMembershipMembershipID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UGHModels.User", b =>
                {
                    b.HasOne("UGHApi.Models.Membership", "CurrentMembership")
                        .WithMany()
                        .HasForeignKey("CurrentMembershipMembershipID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CurrentMembership");
                });
#pragma warning restore 612, 618
        }
    }
}