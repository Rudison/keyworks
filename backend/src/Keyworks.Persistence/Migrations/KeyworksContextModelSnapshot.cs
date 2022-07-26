﻿// <auto-generated />
using System;
using Keyworks.Persistence.Contextos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Keyworks.Persistence.Migrations
{
    [DbContext(typeof(KeyworksContext))]
    partial class KeyworksContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Keyworks.Domain.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataPrevisao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<string>("Equipe")
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeProjeto")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Previsto")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Saldo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SituacaoCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StatusCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TituloId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SituacaoCardId");

                    b.HasIndex("StatusCardId");

                    b.HasIndex("TituloId");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataPrevisao = new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 1,
                            StatusId = 1,
                            TituloId = 1
                        },
                        new
                        {
                            Id = 2,
                            DataPrevisao = new DateTime(2022, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Criar o select para o relatorio de vendas",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR SELECT DO RELATORIO",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 1,
                            StatusId = 2,
                            TituloId = 1
                        },
                        new
                        {
                            Id = 3,
                            DataPrevisao = new DateTime(2022, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Criar nova hud para pontuacao",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR NOVA HUD",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 2,
                            StatusId = 2,
                            TituloId = 2
                        },
                        new
                        {
                            Id = 4,
                            DataPrevisao = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Desenvolver o painel conforme os padroes",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR PAINEL DE CONTROLE",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 4,
                            StatusId = 1,
                            TituloId = 3
                        },
                        new
                        {
                            Id = 5,
                            DataPrevisao = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 3,
                            StatusId = 2,
                            TituloId = 2
                        },
                        new
                        {
                            Id = 6,
                            DataPrevisao = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 2,
                            StatusId = 4,
                            TituloId = 3
                        },
                        new
                        {
                            Id = 7,
                            DataPrevisao = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 2,
                            StatusId = 4,
                            TituloId = 3
                        },
                        new
                        {
                            Id = 8,
                            DataPrevisao = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 3,
                            StatusId = 5,
                            TituloId = 3
                        },
                        new
                        {
                            Id = 9,
                            DataPrevisao = new DateTime(2022, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Usar a branch master, fazer pull",
                            Equipe = "AS, PH, WC",
                            NomeProjeto = "CRIAR MIGRATION",
                            Previsto = new TimeSpan(0, 0, 5, 10, 0),
                            Saldo = new TimeSpan(0, 0, 5, 5, 0),
                            SituacaoId = 3,
                            StatusId = 5,
                            TituloId = 3
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colaboradores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "Afonso",
                            Sobrenome = "Solano"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "Pedro",
                            Sobrenome = "Henrique"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "Wellington",
                            Sobrenome = "Oliveira"
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.Painel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("PosicaoHorizontal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PosicaoVertical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SituacaoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Paineis");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PosicaoHorizontal = 0,
                            PosicaoVertical = 0,
                            SituacaoId = 1
                        },
                        new
                        {
                            Id = 2,
                            PosicaoHorizontal = 1,
                            PosicaoVertical = 0,
                            SituacaoId = 2
                        },
                        new
                        {
                            Id = 3,
                            PosicaoHorizontal = 2,
                            PosicaoVertical = 0,
                            SituacaoId = 3
                        },
                        new
                        {
                            Id = 4,
                            PosicaoHorizontal = 3,
                            PosicaoVertical = 0,
                            SituacaoId = 4
                        },
                        new
                        {
                            Id = 5,
                            PosicaoHorizontal = 4,
                            PosicaoVertical = 0,
                            SituacaoId = 4
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.PainelCards", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PainelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CardId");

                    b.HasIndex("PainelId");

                    b.ToTable("PainelCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardId = 1,
                            PainelId = 1
                        },
                        new
                        {
                            Id = 2,
                            CardId = 2,
                            PainelId = 1
                        },
                        new
                        {
                            Id = 3,
                            CardId = 3,
                            PainelId = 2
                        },
                        new
                        {
                            Id = 4,
                            CardId = 4,
                            PainelId = 4
                        },
                        new
                        {
                            Id = 5,
                            CardId = 5,
                            PainelId = 3
                        },
                        new
                        {
                            Id = 6,
                            CardId = 6,
                            PainelId = 4
                        },
                        new
                        {
                            Id = 7,
                            CardId = 7,
                            PainelId = 4
                        },
                        new
                        {
                            Id = 8,
                            CardId = 8,
                            PainelId = 4
                        },
                        new
                        {
                            Id = 9,
                            CardId = 9,
                            PainelId = 5
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.SituacaoCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PainelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PainelId");

                    b.ToTable("SituacaoCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Aguardando"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Em Adamento"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Pendência"
                        },
                        new
                        {
                            Id = 4,
                            Descricao = "Finalizado"
                        },
                        new
                        {
                            Id = 5,
                            Descricao = "Outros"
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.StatusCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("StatusCards");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Em Dia"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "Atenção"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Em Atraso"
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.Titulo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descricao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Titulos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descricao = "Desenvolvimento"
                        },
                        new
                        {
                            Id = 2,
                            Descricao = "UX|UI"
                        },
                        new
                        {
                            Id = 3,
                            Descricao = "Financeiro"
                        });
                });

            modelBuilder.Entity("Keyworks.Domain.Card", b =>
                {
                    b.HasOne("Keyworks.Domain.SituacaoCard", "SituacaoCard")
                        .WithMany()
                        .HasForeignKey("SituacaoCardId");

                    b.HasOne("Keyworks.Domain.StatusCard", "StatusCard")
                        .WithMany()
                        .HasForeignKey("StatusCardId");

                    b.HasOne("Keyworks.Domain.Titulo", "Titulo")
                        .WithMany()
                        .HasForeignKey("TituloId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SituacaoCard");

                    b.Navigation("StatusCard");

                    b.Navigation("Titulo");
                });

            modelBuilder.Entity("Keyworks.Domain.PainelCards", b =>
                {
                    b.HasOne("Keyworks.Domain.Card", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Keyworks.Domain.Painel", "Painel")
                        .WithMany("PainelCards")
                        .HasForeignKey("PainelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Painel");
                });

            modelBuilder.Entity("Keyworks.Domain.SituacaoCard", b =>
                {
                    b.HasOne("Keyworks.Domain.Painel", null)
                        .WithMany("SituacaoCard")
                        .HasForeignKey("PainelId");
                });

            modelBuilder.Entity("Keyworks.Domain.Painel", b =>
                {
                    b.Navigation("PainelCards");

                    b.Navigation("SituacaoCard");
                });
#pragma warning restore 612, 618
        }
    }
}
