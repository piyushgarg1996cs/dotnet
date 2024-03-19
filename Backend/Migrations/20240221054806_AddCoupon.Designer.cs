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
    [Migration("20240221054806_AddCoupon")]
    partial class AddCoupon
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Backend.Models.EmailVerificator", b =>
                {
                    b.Property<int>("verivicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("requestDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("user_Id")
                        .HasColumnType("int");

                    b.Property<Guid>("verificationToken")
                        .HasColumnType("char(36)");

                    b.HasKey("verivicationID");

                    b.ToTable("EmailVerificators");
                });

            modelBuilder.Entity("UGHApi.Models.Continent", b =>
                {
                    b.Property<int>("Continent_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Continent_ID");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("UGHApi.Models.Country", b =>
                {
                    b.Property<int>("Country_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .HasColumnType("longtext");

                    b.Property<int?>("Region_ID")
                        .HasColumnType("int");

                    b.HasKey("Country_ID");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("UGHApi.Models.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("DiscountAmount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Coupons");
                });

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

            modelBuilder.Entity("UGHApi.Models.Redemption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CouponId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RedeemedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.ToTable("Redemptions");
                });

            modelBuilder.Entity("UGHApi.Models.Region", b =>
                {
                    b.Property<int>("Region_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContinentID")
                        .HasColumnType("int");

                    b.Property<int?>("CountryID")
                        .HasColumnType("int");

                    b.Property<string>("RegionName")
                        .HasColumnType("longtext");

                    b.HasKey("Region_ID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("UGHApi.Models.Skill", b =>
                {
                    b.Property<int>("Skill_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ParentSkill_ID")
                        .HasColumnType("int");

                    b.Property<string>("SkillDescrition")
                        .HasColumnType("longtext");

                    b.HasKey("Skill_ID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("UGHApi.Models.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("UGHApi.Models.UserRoleMapping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRolesMapping");
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

                    b.Property<int?>("CurrentMembershipMembershipID")
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

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SaltKey")
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

            modelBuilder.Entity("UGHApi.Models.Redemption", b =>
                {
                    b.HasOne("UGHApi.Models.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coupon");
                });

            modelBuilder.Entity("UGHApi.Models.UserRoleMapping", b =>
                {
                    b.HasOne("UGHApi.Models.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UGHModels.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UGHModels.User", b =>
                {
                    b.HasOne("UGHApi.Models.Membership", "CurrentMembership")
                        .WithMany()
                        .HasForeignKey("CurrentMembershipMembershipID");

                    b.Navigation("CurrentMembership");
                });
#pragma warning restore 612, 618
        }
    }
}
