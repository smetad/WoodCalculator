﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using woodcalc_00;

namespace woodcalc_00.Migrations
{
    [DbContext(typeof(LogContext))]
    partial class LogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("woodcalc_00.Calculation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfCalculation")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Calculations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TypeOfCalculation = "Huberův vzorec"
                        },
                        new
                        {
                            Id = 2,
                            TypeOfCalculation = "Smalianův vzorec"
                        },
                        new
                        {
                            Id = 3,
                            TypeOfCalculation = "Newtonův vzorec"
                        },
                        new
                        {
                            Id = 4,
                            TypeOfCalculation = "ČSN 48 0007"
                        },
                        new
                        {
                            Id = 5,
                            TypeOfCalculation = "ČSN 48 0009"
                        });
                });

            modelBuilder.Entity("woodcalc_00.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Bark")
                        .HasColumnType("REAL");

                    b.Property<int>("CalculationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("DiameterBottom")
                        .HasColumnType("REAL");

                    b.Property<double>("DiameterMiddle")
                        .HasColumnType("REAL");

                    b.Property<double>("DiameterTop")
                        .HasColumnType("REAL");

                    b.Property<double>("Length")
                        .HasColumnType("REAL");

                    b.Property<int?>("QualityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tag")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TreeId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Value")
                        .HasColumnType("REAL");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("CalculationId");

                    b.HasIndex("QualityId");

                    b.HasIndex("TreeId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("woodcalc_00.Model.CalculationParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalculationId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("E0")
                        .HasColumnType("REAL");

                    b.Property<double>("E1")
                        .HasColumnType("REAL");

                    b.Property<double>("E2")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CalculationId");

                    b.ToTable("CalculationParameters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalculationId = 5,
                            E0 = 0.57723000000000002,
                            E1 = 0.0068970000000000004,
                            E2 = 1.3123,
                            Name = "1. skupina"
                        },
                        new
                        {
                            Id = 2,
                            CalculationId = 5,
                            E0 = 0.24016999999999999,
                            E1 = 0.001915,
                            E2 = 1.7866,
                            Name = "2. skupina"
                        },
                        new
                        {
                            Id = 3,
                            CalculationId = 5,
                            E0 = 1.7015,
                            E1 = 0.0087620000000000007,
                            E2 = 1.4568000000000001,
                            Name = "3. skupina"
                        },
                        new
                        {
                            Id = 4,
                            CalculationId = 5,
                            E0 = -0.04088,
                            E1 = 0.16633999999999999,
                            E2 = 0.56076000000000004,
                            Name = "4. skupina"
                        },
                        new
                        {
                            Id = 5,
                            CalculationId = 5,
                            E0 = 1.2474000000000001,
                            E1 = 0.042323,
                            E2 = 1.0623,
                            Name = "5. skupina"
                        });
                });

            modelBuilder.Entity("woodcalc_00.Model.Quality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("QualityClass")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Qualities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            QualityClass = "A"
                        },
                        new
                        {
                            Id = 2,
                            QualityClass = "B"
                        },
                        new
                        {
                            Id = 3,
                            QualityClass = "C"
                        },
                        new
                        {
                            Id = 4,
                            QualityClass = "D"
                        });
                });

            modelBuilder.Entity("woodcalc_00.Tree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CalculationParametersId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TypeOfTree")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CalculationParametersId");

                    b.ToTable("Trees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CalculationParametersId = 1,
                            TypeOfTree = "smrk"
                        },
                        new
                        {
                            Id = 2,
                            CalculationParametersId = 1,
                            TypeOfTree = "jedle"
                        },
                        new
                        {
                            Id = 3,
                            CalculationParametersId = 2,
                            TypeOfTree = "borovice - kůra"
                        },
                        new
                        {
                            Id = 4,
                            CalculationParametersId = 2,
                            TypeOfTree = "borovice vejmutovka"
                        },
                        new
                        {
                            Id = 5,
                            CalculationParametersId = 2,
                            TypeOfTree = "douglaska"
                        },
                        new
                        {
                            Id = 6,
                            CalculationParametersId = 3,
                            TypeOfTree = "borovice - borka (oddenkové výřezy)"
                        },
                        new
                        {
                            Id = 7,
                            CalculationParametersId = 3,
                            TypeOfTree = "modřín"
                        },
                        new
                        {
                            Id = 8,
                            CalculationParametersId = 4,
                            TypeOfTree = "buk"
                        },
                        new
                        {
                            Id = 9,
                            CalculationParametersId = 4,
                            TypeOfTree = "habr"
                        },
                        new
                        {
                            Id = 10,
                            CalculationParametersId = 4,
                            TypeOfTree = "javor"
                        },
                        new
                        {
                            Id = 11,
                            CalculationParametersId = 4,
                            TypeOfTree = "jeřáb"
                        },
                        new
                        {
                            Id = 12,
                            CalculationParametersId = 4,
                            TypeOfTree = "lípa"
                        },
                        new
                        {
                            Id = 13,
                            CalculationParametersId = 4,
                            TypeOfTree = "osika"
                        },
                        new
                        {
                            Id = 14,
                            CalculationParametersId = 5,
                            TypeOfTree = "bříza"
                        },
                        new
                        {
                            Id = 15,
                            CalculationParametersId = 5,
                            TypeOfTree = "dub"
                        },
                        new
                        {
                            Id = 16,
                            CalculationParametersId = 5,
                            TypeOfTree = "jasan"
                        },
                        new
                        {
                            Id = 17,
                            CalculationParametersId = 5,
                            TypeOfTree = "jilm"
                        },
                        new
                        {
                            Id = 18,
                            CalculationParametersId = 5,
                            TypeOfTree = "olše"
                        },
                        new
                        {
                            Id = 19,
                            CalculationParametersId = 5,
                            TypeOfTree = "topol"
                        });
                });

            modelBuilder.Entity("woodcalc_00.Log", b =>
                {
                    b.HasOne("woodcalc_00.Calculation", "Calculation")
                        .WithMany("Logs")
                        .HasForeignKey("CalculationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("woodcalc_00.Model.Quality", "Quality")
                        .WithMany("Logs")
                        .HasForeignKey("QualityId");

                    b.HasOne("woodcalc_00.Tree", "Tree")
                        .WithMany("Logs")
                        .HasForeignKey("TreeId");

                    b.Navigation("Calculation");

                    b.Navigation("Quality");

                    b.Navigation("Tree");
                });

            modelBuilder.Entity("woodcalc_00.Model.CalculationParameters", b =>
                {
                    b.HasOne("woodcalc_00.Calculation", "Calculation")
                        .WithMany("CalculationParameters")
                        .HasForeignKey("CalculationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calculation");
                });

            modelBuilder.Entity("woodcalc_00.Tree", b =>
                {
                    b.HasOne("woodcalc_00.Model.CalculationParameters", "CalculationParameters")
                        .WithMany("Trees")
                        .HasForeignKey("CalculationParametersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CalculationParameters");
                });

            modelBuilder.Entity("woodcalc_00.Calculation", b =>
                {
                    b.Navigation("CalculationParameters");

                    b.Navigation("Logs");
                });

            modelBuilder.Entity("woodcalc_00.Model.CalculationParameters", b =>
                {
                    b.Navigation("Trees");
                });

            modelBuilder.Entity("woodcalc_00.Model.Quality", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("woodcalc_00.Tree", b =>
                {
                    b.Navigation("Logs");
                });
#pragma warning restore 612, 618
        }
    }
}
