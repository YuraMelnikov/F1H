using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace F1H.Migrations
{
    public partial class ProjectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Link = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Size = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagesGPConfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesGPConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagesGPFlags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesGPFlags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagesGPLivers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesGPLivers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImagesGPRacers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagesGPRacers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeCalculates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    DescriptionEn = table.Column<string>(nullable: false),
                    DescriptionRus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCalculates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeDNQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDNQs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeFails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeFinishes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ShortName = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeFinishes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StartPositionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: false),
                    Map = table.Column<string>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StartPositionTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StartPositionTypes_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    NameEn = table.Column<string>(nullable: false),
                    NameRus = table.Column<string>(nullable: false),
                    IdImageGpFlag = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Country_ImagesGPFlags_IdImageGpFlag",
                        column: x => x.IdImageGpFlag,
                        principalTable: "ImagesGPFlags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Year = table.Column<int>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    IdTypeCalculate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seasons_TypeCalculates_IdTypeCalculate",
                        column: x => x.IdTypeCalculate,
                        principalTable: "TypeCalculates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdCountry = table.Column<int>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Racers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdCountry = table.Column<int>(nullable: false),
                    Born = table.Column<DateTime>(nullable: false),
                    BornIn = table.Column<string>(nullable: false),
                    Dead = table.Column<DateTime>(nullable: false),
                    DeadIn = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    SecondName = table.Column<string>(nullable: false),
                    IndexPhoto = table.Column<int>(nullable: false),
                    TextData = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Racers_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Racers_ImagesGPRacers_IndexPhoto",
                        column: x => x.IndexPhoto,
                        principalTable: "ImagesGPRacers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdCountry = table.Column<int>(nullable: false),
                    ShortName = table.Column<string>(nullable: false),
                    IndexPhoto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teams_Images_IndexPhoto",
                        column: x => x.IndexPhoto,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdCountry = table.Column<int>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    NameEn = table.Column<string>(nullable: false),
                    NameRus = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tracks_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chassis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdManufacturer = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    IdImageGPLivery = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chassis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chassis_ImagesGPLivers_IdImageGPLivery",
                        column: x => x.IdImageGPLivery,
                        principalTable: "ImagesGPLivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chassis_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chassis_Manufacturers_IdManufacturer",
                        column: x => x.IdManufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Engines",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdManufacturer = table.Column<int>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Engines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Engines_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Engines_Manufacturers_IdManufacturer",
                        column: x => x.IdManufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tyres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdManufacturer = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tyres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tyres_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tyres_Manufacturers_IdManufacturer",
                        column: x => x.IdManufacturer,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GPs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdTrack = table.Column<int>(nullable: false),
                    Num = table.Column<int>(nullable: false),
                    NumInSeason = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false),
                    Weather = table.Column<string>(nullable: false),
                    PercentDistance = table.Column<float>(nullable: false),
                    IdStartPositionType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPs_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GPs_StartPositionTypes_IdStartPositionType",
                        column: x => x.IdStartPositionType,
                        principalTable: "StartPositionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GPs_Tracks_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrackСonfigurations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdTrack = table.Column<int>(nullable: false),
                    IdSeason = table.Column<int>(nullable: false),
                    IdImagesGpConfiguration = table.Column<int>(nullable: false),
                    Length = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    IdImageGp = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackСonfigurations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrackСonfigurations_Images_IdImageGp",
                        column: x => x.IdImageGp,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrackСonfigurations_ImagesGPConfigurations_IdImagesGpConfig~",
                        column: x => x.IdImagesGpConfiguration,
                        principalTable: "ImagesGPConfigurations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrackСonfigurations_Seasons_IdSeason",
                        column: x => x.IdSeason,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrackСonfigurations_Tracks_IdTrack",
                        column: x => x.IdTrack,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGp = table.Column<int>(nullable: false),
                    Num = table.Column<string>(nullable: false),
                    IdTeam = table.Column<int>(nullable: false),
                    IdChassi = table.Column<int>(nullable: false),
                    IdEngine = table.Column<int>(nullable: false),
                    IdRacer = table.Column<int>(nullable: false),
                    IdTyre = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participants_Chassis_IdChassi",
                        column: x => x.IdChassi,
                        principalTable: "Chassis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Engines_IdEngine",
                        column: x => x.IdEngine,
                        principalTable: "Engines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_GPs_IdGp",
                        column: x => x.IdGp,
                        principalTable: "GPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Racers_IdRacer",
                        column: x => x.IdRacer,
                        principalTable: "Racers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Teams_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Participants_Tyres_IdTyre",
                        column: x => x.IdTyre,
                        principalTable: "Tyres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GPResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdParticipant = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    AverageSpeed = table.Column<float>(nullable: false),
                    IdTypeFinish = table.Column<int>(nullable: false),
                    Lap = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPResults_Participants_IdParticipant",
                        column: x => x.IdParticipant,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GPResults_TypeFinishes_IdTypeFinish",
                        column: x => x.IdTypeFinish,
                        principalTable: "TypeFinishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdParticipant = table.Column<int>(nullable: false),
                    Position = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    AverageSpeed = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Qualifications_Participants_IdParticipant",
                        column: x => x.IdParticipant,
                        principalTable: "Participants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DNQs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGpResult = table.Column<int>(nullable: false),
                    IdTypeDnq = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DNQs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DNQs_GPResults_IdGpResult",
                        column: x => x.IdGpResult,
                        principalTable: "GPResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DNQs_TypeDNQs_IdTypeDnq",
                        column: x => x.IdTypeDnq,
                        principalTable: "TypeDNQs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGpResult = table.Column<int>(nullable: false),
                    IdTypeFail = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fails_GPResults_IdGpResult",
                        column: x => x.IdGpResult,
                        principalTable: "GPResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fails_TypeFails_IdTypeFail",
                        column: x => x.IdTypeFail,
                        principalTable: "TypeFails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FastLaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGpResult = table.Column<int>(nullable: false),
                    Lap = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: false),
                    AverageSpeed = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastLaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FastLaps_GPResults_IdGpResult",
                        column: x => x.IdGpResult,
                        principalTable: "GPResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaderLaps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGpResult = table.Column<int>(nullable: false),
                    First = table.Column<int>(nullable: false),
                    Last = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaderLaps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaderLaps_GPResults_IdGpResult",
                        column: x => x.IdGpResult,
                        principalTable: "GPResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    IdGpResult = table.Column<int>(nullable: false),
                    Lap = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pits_GPResults_IdGpResult",
                        column: x => x.IdGpResult,
                        principalTable: "GPResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_IdImageGPLivery",
                table: "Chassis",
                column: "IdImageGPLivery");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_IdImageGp",
                table: "Chassis",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Chassis_IdManufacturer",
                table: "Chassis",
                column: "IdManufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Country_IdImageGpFlag",
                table: "Country",
                column: "IdImageGpFlag");

            migrationBuilder.CreateIndex(
                name: "IX_DNQs_IdGpResult",
                table: "DNQs",
                column: "IdGpResult");

            migrationBuilder.CreateIndex(
                name: "IX_DNQs_IdTypeDnq",
                table: "DNQs",
                column: "IdTypeDnq");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_IdImageGp",
                table: "Engines",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Engines_IdManufacturer",
                table: "Engines",
                column: "IdManufacturer");

            migrationBuilder.CreateIndex(
                name: "IX_Fails_IdGpResult",
                table: "Fails",
                column: "IdGpResult");

            migrationBuilder.CreateIndex(
                name: "IX_Fails_IdTypeFail",
                table: "Fails",
                column: "IdTypeFail");

            migrationBuilder.CreateIndex(
                name: "IX_FastLaps_IdGpResult",
                table: "FastLaps",
                column: "IdGpResult");

            migrationBuilder.CreateIndex(
                name: "IX_GPResults_IdParticipant",
                table: "GPResults",
                column: "IdParticipant");

            migrationBuilder.CreateIndex(
                name: "IX_GPResults_IdTypeFinish",
                table: "GPResults",
                column: "IdTypeFinish");

            migrationBuilder.CreateIndex(
                name: "IX_GPs_IdImageGp",
                table: "GPs",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_GPs_IdStartPositionType",
                table: "GPs",
                column: "IdStartPositionType");

            migrationBuilder.CreateIndex(
                name: "IX_GPs_IdTrack",
                table: "GPs",
                column: "IdTrack");

            migrationBuilder.CreateIndex(
                name: "IX_LeaderLaps_IdGpResult",
                table: "LeaderLaps",
                column: "IdGpResult");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_IdCountry",
                table: "Manufacturers",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_IdImageGp",
                table: "Manufacturers",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdChassi",
                table: "Participants",
                column: "IdChassi");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdEngine",
                table: "Participants",
                column: "IdEngine");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdGp",
                table: "Participants",
                column: "IdGp");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdRacer",
                table: "Participants",
                column: "IdRacer");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdTeam",
                table: "Participants",
                column: "IdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_IdTyre",
                table: "Participants",
                column: "IdTyre");

            migrationBuilder.CreateIndex(
                name: "IX_Pits_IdGpResult",
                table: "Pits",
                column: "IdGpResult");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_IdParticipant",
                table: "Qualifications",
                column: "IdParticipant");

            migrationBuilder.CreateIndex(
                name: "IX_Racers_IdCountry",
                table: "Racers",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Racers_IndexPhoto",
                table: "Racers",
                column: "IndexPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_IdImageGp",
                table: "Seasons",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_IdTypeCalculate",
                table: "Seasons",
                column: "IdTypeCalculate");

            migrationBuilder.CreateIndex(
                name: "IX_StartPositionTypes_IdImageGp",
                table: "StartPositionTypes",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_IdCountry",
                table: "Teams",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_IndexPhoto",
                table: "Teams",
                column: "IndexPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdCountry",
                table: "Tracks",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_IdImageGp",
                table: "Tracks",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_TrackСonfigurations_IdImageGp",
                table: "TrackСonfigurations",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_TrackСonfigurations_IdImagesGpConfiguration",
                table: "TrackСonfigurations",
                column: "IdImagesGpConfiguration");

            migrationBuilder.CreateIndex(
                name: "IX_TrackСonfigurations_IdSeason",
                table: "TrackСonfigurations",
                column: "IdSeason");

            migrationBuilder.CreateIndex(
                name: "IX_TrackСonfigurations_IdTrack",
                table: "TrackСonfigurations",
                column: "IdTrack");

            migrationBuilder.CreateIndex(
                name: "IX_Tyres_IdImageGp",
                table: "Tyres",
                column: "IdImageGp");

            migrationBuilder.CreateIndex(
                name: "IX_Tyres_IdManufacturer",
                table: "Tyres",
                column: "IdManufacturer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DNQs");

            migrationBuilder.DropTable(
                name: "Fails");

            migrationBuilder.DropTable(
                name: "FastLaps");

            migrationBuilder.DropTable(
                name: "LeaderLaps");

            migrationBuilder.DropTable(
                name: "Pits");

            migrationBuilder.DropTable(
                name: "Qualifications");

            migrationBuilder.DropTable(
                name: "TrackСonfigurations");

            migrationBuilder.DropTable(
                name: "TypeDNQs");

            migrationBuilder.DropTable(
                name: "TypeFails");

            migrationBuilder.DropTable(
                name: "GPResults");

            migrationBuilder.DropTable(
                name: "ImagesGPConfigurations");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "TypeFinishes");

            migrationBuilder.DropTable(
                name: "TypeCalculates");

            migrationBuilder.DropTable(
                name: "Chassis");

            migrationBuilder.DropTable(
                name: "Engines");

            migrationBuilder.DropTable(
                name: "GPs");

            migrationBuilder.DropTable(
                name: "Racers");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Tyres");

            migrationBuilder.DropTable(
                name: "ImagesGPLivers");

            migrationBuilder.DropTable(
                name: "StartPositionTypes");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "ImagesGPRacers");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ImagesGPFlags");
        }
    }
}
