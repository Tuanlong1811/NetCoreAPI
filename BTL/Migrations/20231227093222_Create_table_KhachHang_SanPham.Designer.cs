﻿// <auto-generated />
using BTL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231227093222_Create_table_KhachHang_SanPham")]
    partial class Create_table_KhachHang_SanPham
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("BTL.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKhachHang")
                        .HasColumnType("TEXT");

                    b.Property<string>("DiaChiKhachHang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SDTKhachHang")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("BTL.Models.Person", b =>
                {
                    b.Property<string>("PersonID")
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("BTL.Models.SanPham", b =>
                {
                    b.Property<int>("MaSP")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("GiaSP")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SoLuongSP")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TenSP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TinhTrangSP")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSP");

                    b.ToTable("SanPham");
                });
#pragma warning restore 612, 618
        }
    }
}
