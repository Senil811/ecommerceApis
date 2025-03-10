﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ecommerceApis.Data;

#nullable disable

namespace ecommerceApis.Migrations
{
    [DbContext(typeof(EcommerceContext))]
    partial class EcommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ecommerceApis.Data.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cart_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("CartId")
                        .HasName("PK__Cart__2EF52A273280B6AC");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("ecommerceApis.Data.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("comment_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<string>("CommentText")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("comment_text");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("CommentId")
                        .HasName("PK__Comments__E7957687774C3D86");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ecommerceApis.Data.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime")
                        .HasColumnName("order_date");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total_price");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__46596229ED2FAEAE");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ecommerceApis.Data.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("product_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image");

                    b.Property<decimal?>("Pricing")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("pricing");

                    b.Property<decimal?>("ShippingCost")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("shipping_cost");

                    b.HasKey("ProductId")
                        .HasName("PK__Product__47027DF522067A22");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("ecommerceApis.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("PurchaseHistory")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("purchase_history");

                    b.Property<string>("ShippingAddress")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("shipping_address");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("username");

                    b.HasKey("UserId")
                        .HasName("PK__Users__B9BE370F3741649D");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ecommerceApis.Data.Cart", b =>
                {
                    b.HasOne("ecommerceApis.Data.Product", "Product")
                        .WithMany("Carts")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Cart__product_id__403A8C7D");

                    b.HasOne("ecommerceApis.Data.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Cart__user_id__3F466844");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ecommerceApis.Data.Comment", b =>
                {
                    b.HasOne("ecommerceApis.Data.Product", "Product")
                        .WithMany("Comments")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Comments__produc__3B75D760");

                    b.HasOne("ecommerceApis.Data.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Comments__user_i__3C69FB99");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ecommerceApis.Data.Order", b =>
                {
                    b.HasOne("ecommerceApis.Data.Product", "Product")
                        .WithMany("Orders")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__Orders__product___440B1D61");

                    b.HasOne("ecommerceApis.Data.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Orders__user_id__4316F928");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ecommerceApis.Data.Product", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("ecommerceApis.Data.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
