﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerce.API.Database;

#nullable disable

namespace eCommerce.API.Migrations
{
    [DbContext(typeof(eCommerceContext))]
    [Migration("20230223170458_ImplementandoFluentApi")]
    partial class ImplementandoFluentApi
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eCommerce.Models.Contato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Celular");

                    b.Property<string>("Telefone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Telefone");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Contatos", (string)null);
                });

            modelBuilder.Entity("eCommerce.Models.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Departamentos", (string)null);
                });

            modelBuilder.Entity("eCommerce.Models.EnderecoEntrega", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Bairro");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Cidade");

                    b.Property<string>("Complemento")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Complemento");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Endereco");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Estado");

                    b.Property<string>("NomeEndereco")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NomeEndereco");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Numero");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("EnderecosEntrega", (string)null);
                });

            modelBuilder.Entity("eCommerce.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar")
                        .HasColumnName("CPF");

                    b.Property<DateTime>("DataCadastro")
                        .HasMaxLength(19)
                        .HasColumnType("datetime")
                        .HasColumnName("DataCadastro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar")
                        .HasColumnName("Nome");

                    b.Property<string>("NomeMae")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar")
                        .HasColumnName("NomeMae");

                    b.Property<string>("RG")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar")
                        .HasColumnName("RG");

                    b.Property<int?>("SituacaoCadastral")
                        .HasColumnType("int")
                        .HasColumnName("SituacaoCadastral");

                    b.HasKey("Id");

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("eCommerce.Models.UsuarioDepartamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int")
                        .HasColumnName("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioDepartamentos", (string)null);
                });

            modelBuilder.Entity("eCommerce.Models.Contato", b =>
                {
                    b.HasOne("eCommerce.Models.Usuario", null)
                        .WithOne("Contato")
                        .HasForeignKey("eCommerce.Models.Contato", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Models.EnderecoEntrega", b =>
                {
                    b.HasOne("eCommerce.Models.Usuario", null)
                        .WithMany("EnderecosEntrega")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerce.Models.UsuarioDepartamentos", b =>
                {
                    b.HasOne("eCommerce.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerce.Models.Usuario", null)
                        .WithMany("Departamentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("eCommerce.Models.Usuario", b =>
                {
                    b.Navigation("Contato");

                    b.Navigation("Departamentos");

                    b.Navigation("EnderecosEntrega");
                });
#pragma warning restore 612, 618
        }
    }
}