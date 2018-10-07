﻿// <auto-generated />
using System;
using F1H.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F1H.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20181007093502_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("F1H.Models.Chassi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<int?>("IdImageGpChassi");

                    b.Property<int>("IdImagesGpChassi");

                    b.Property<int>("IdManufacturer");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdImageGpChassi");

                    b.HasIndex("IdManufacturer");

                    b.ToTable("Chassis");
                });

            modelBuilder.Entity("F1H.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGpFlag");

                    b.Property<string>("NameEn")
                        .IsRequired();

                    b.Property<string>("NameRus")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGpFlag");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("F1H.Models.DescriptionResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdGpResult");

                    b.Property<string>("TextData")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.ToTable("DescriptionResults");
                });

            modelBuilder.Entity("F1H.Models.DNQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdGpResult");

                    b.Property<int>("IdTypeDnq");

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.HasIndex("IdTypeDnq");

                    b.ToTable("DNQs");
                });

            modelBuilder.Entity("F1H.Models.Engine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<int>("IdManufacturer");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdManufacturer");

                    b.ToTable("Engines");
                });

            modelBuilder.Entity("F1H.Models.Fail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdGpResult");

                    b.Property<int>("IdTypeFail");

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.HasIndex("IdTypeFail");

                    b.ToTable("Fails");
                });

            modelBuilder.Entity("F1H.Models.FastLap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageSpeed");

                    b.Property<int>("IdGpResult");

                    b.Property<int>("Lap");

                    b.Property<string>("Time")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.ToTable("FastLaps");
                });

            modelBuilder.Entity("F1H.Models.GP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("IdImageGp");

                    b.Property<int>("IdStartPositionType");

                    b.Property<int>("IdTrack");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("Num");

                    b.Property<int>("NumInSeason");

                    b.Property<float>("PercentDistance");

                    b.Property<string>("Weather")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdStartPositionType");

                    b.HasIndex("IdTrack");

                    b.ToTable("GPs");
                });

            modelBuilder.Entity("F1H.Models.GPResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageSpeed");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("IdParticipant");

                    b.Property<int>("IdTypeFinish");

                    b.Property<int>("Lap");

                    b.Property<string>("Num")
                        .IsRequired();

                    b.Property<int>("Position");

                    b.Property<string>("Time")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdParticipant");

                    b.HasIndex("IdTypeFinish");

                    b.ToTable("GPResults");
                });

            modelBuilder.Entity("F1H.Models.ImageGP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Link")
                        .IsRequired();

                    b.Property<int>("Size");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("F1H.Models.ImageGPConfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ImagesGPConfigurations");
                });

            modelBuilder.Entity("F1H.Models.ImageGPFlag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ImagesGPFlags");
                });

            modelBuilder.Entity("F1H.Models.ImageGPLiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ImagesGPLivers");
                });

            modelBuilder.Entity("F1H.Models.ImageGPRacers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ImagesGPRacers");
                });

            modelBuilder.Entity("F1H.Models.LeaderLap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("First");

                    b.Property<int>("IdGpResult");

                    b.Property<int>("Last");

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.ToTable("LeaderLaps");
                });

            modelBuilder.Entity("F1H.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCountry");

                    b.Property<int>("IdImageGp");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IdImageGp");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("F1H.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdChassi");

                    b.Property<int>("IdEngine");

                    b.Property<int>("IdGp");

                    b.Property<int>("IdRacer");

                    b.Property<int>("IdTeam");

                    b.Property<int>("IdTyre");

                    b.Property<string>("Num")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdChassi");

                    b.HasIndex("IdEngine");

                    b.HasIndex("IdGp");

                    b.HasIndex("IdRacer");

                    b.HasIndex("IdTeam");

                    b.HasIndex("IdTyre");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("F1H.Models.Pit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdGpResult");

                    b.Property<int>("Lap");

                    b.HasKey("Id");

                    b.HasIndex("IdGpResult");

                    b.ToTable("Pits");
                });

            modelBuilder.Entity("F1H.Models.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageSpeed");

                    b.Property<int>("IdParticipant");

                    b.Property<string>("Num")
                        .IsRequired();

                    b.Property<int>("Position");

                    b.Property<string>("Time")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdParticipant");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("F1H.Models.Racer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Born");

                    b.Property<string>("BornIn")
                        .IsRequired();

                    b.Property<DateTime>("Dead");

                    b.Property<string>("DeadIn")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("IdCountry");

                    b.Property<int>("IndexPhoto");

                    b.Property<string>("SecondName")
                        .IsRequired();

                    b.Property<string>("TextData")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IndexPhoto");

                    b.ToTable("Racers");
                });

            modelBuilder.Entity("F1H.Models.Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<int>("IdTypeCalculate");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdTypeCalculate");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("F1H.Models.StartPositionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<string>("Map")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.ToTable("StartPositionTypes");
                });

            modelBuilder.Entity("F1H.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCountry");

                    b.Property<int>("IndexPhoto");

                    b.Property<string>("ShortName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IndexPhoto");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("F1H.Models.TeamName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<int>("IdTeam");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.HasIndex("IdTeam");

                    b.ToTable("TeamNames");
                });

            modelBuilder.Entity("F1H.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCountry");

                    b.Property<int>("IdImageGp");

                    b.Property<string>("NameEn")
                        .IsRequired();

                    b.Property<string>("NameRus")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdCountry");

                    b.HasIndex("IdImageGp");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("F1H.Models.TrackСonfiguration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<int>("IdImagesGpConfiguration");

                    b.Property<int>("IdSeason");

                    b.Property<int>("IdTrack");

                    b.Property<int>("Length");

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdImagesGpConfiguration");

                    b.HasIndex("IdSeason");

                    b.HasIndex("IdTrack");

                    b.ToTable("GetTrackСonfigurations");
                });

            modelBuilder.Entity("F1H.Models.TypeCalculate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescriptionEn")
                        .IsRequired();

                    b.Property<string>("DescriptionRus")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypeCalculates");
                });

            modelBuilder.Entity("F1H.Models.TypeDNQ", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypeDNQs");
                });

            modelBuilder.Entity("F1H.Models.TypeFail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypeFails");
                });

            modelBuilder.Entity("F1H.Models.TypeFinish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ShortName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TypeFinishes");
                });

            modelBuilder.Entity("F1H.Models.Tyre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdImageGp");

                    b.Property<int>("IdManufacturer");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdImageGp");

                    b.HasIndex("IdManufacturer");

                    b.ToTable("Tyres");
                });

            modelBuilder.Entity("F1H.Models.Chassi", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGPLiver", "ImageLiver")
                        .WithMany()
                        .HasForeignKey("IdImageGpChassi");

                    b.HasOne("F1H.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("IdManufacturer")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Country", b =>
                {
                    b.HasOne("F1H.Models.ImageGPFlag", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGpFlag")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.DescriptionResult", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.DNQ", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.TypeDNQ", "TypeDnq")
                        .WithMany()
                        .HasForeignKey("IdTypeDnq")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Engine", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("IdManufacturer")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Fail", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.TypeFail", "TFail")
                        .WithMany()
                        .HasForeignKey("IdTypeFail")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.FastLap", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.GP", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.StartPositionType", "StartType")
                        .WithMany()
                        .HasForeignKey("IdStartPositionType")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("IdTrack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.GPResult", b =>
                {
                    b.HasOne("F1H.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("IdParticipant")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.TypeFinish", "TFinish")
                        .WithMany()
                        .HasForeignKey("IdTypeFinish")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.LeaderLap", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Manufacturer", b =>
                {
                    b.HasOne("F1H.Models.Country", "Countr")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Participant", b =>
                {
                    b.HasOne("F1H.Models.Chassi", "Chassi")
                        .WithMany()
                        .HasForeignKey("IdChassi")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Engine", "Engine")
                        .WithMany()
                        .HasForeignKey("IdEngine")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.GP", "Gp")
                        .WithMany()
                        .HasForeignKey("IdGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Racer", "Racer")
                        .WithMany()
                        .HasForeignKey("IdRacer")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Tyre", "Tyre")
                        .WithMany()
                        .HasForeignKey("IdTyre")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Pit", b =>
                {
                    b.HasOne("F1H.Models.GPResult", "Result")
                        .WithMany()
                        .HasForeignKey("IdGpResult")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Qualification", b =>
                {
                    b.HasOne("F1H.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("IdParticipant")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Racer", b =>
                {
                    b.HasOne("F1H.Models.Country", "Countr")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGPRacers", "Image")
                        .WithMany()
                        .HasForeignKey("IndexPhoto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Season", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.TypeCalculate", "TypeCalculat")
                        .WithMany()
                        .HasForeignKey("IdTypeCalculate")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.StartPositionType", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Team", b =>
                {
                    b.HasOne("F1H.Models.Country", "Cournt")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IndexPhoto")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.TeamName", b =>
                {
                    b.HasOne("F1H.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("IdTeam")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Track", b =>
                {
                    b.HasOne("F1H.Models.Country", "Countr")
                        .WithMany()
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGP", "Image")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.TrackСonfiguration", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "ImageGp")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.ImageGPConfiguration", "ImagesGpConfiguratione")
                        .WithMany()
                        .HasForeignKey("IdImagesGpConfiguration")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("IdSeason")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Track", "Track")
                        .WithMany()
                        .HasForeignKey("IdTrack")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("F1H.Models.Tyre", b =>
                {
                    b.HasOne("F1H.Models.ImageGP", "ImageGp")
                        .WithMany()
                        .HasForeignKey("IdImageGp")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1H.Models.Manufacturer", "Manufacturer")
                        .WithMany()
                        .HasForeignKey("IdManufacturer")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
