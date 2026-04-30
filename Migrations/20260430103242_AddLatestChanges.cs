using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSite.Migrations
{
    /// <inheritdoc />
    public partial class AddLatestChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameFa = table.Column<string>(type: "TEXT", nullable: false),
                    NameEn = table.Column<string>(type: "TEXT", nullable: false),
                    NameAr = table.Column<string>(type: "TEXT", nullable: false),
                    ExpertFa = table.Column<string>(type: "TEXT", nullable: false),
                    ExpertEn = table.Column<string>(type: "TEXT", nullable: false),
                    ExpertAr = table.Column<string>(type: "TEXT", nullable: false),
                    ImageAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleFa = table.Column<string>(type: "TEXT", nullable: false),
                    TitleEn = table.Column<string>(type: "TEXT", nullable: false),
                    TitleAr = table.Column<string>(type: "TEXT", nullable: false),
                    SummaryFa = table.Column<string>(type: "TEXT", nullable: false),
                    SummaryEn = table.Column<string>(type: "TEXT", nullable: false),
                    SummaryAr = table.Column<string>(type: "TEXT", nullable: false),
                    ContentFa = table.Column<string>(type: "TEXT", nullable: false),
                    ContentEn = table.Column<string>(type: "TEXT", nullable: false),
                    ContentAr = table.Column<string>(type: "TEXT", nullable: false),
                    AuthorName = table.Column<string>(type: "TEXT", nullable: false),
                    ImageAddress = table.Column<string>(type: "TEXT", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsPublished = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PropertyCode = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    District = table.Column<string>(type: "TEXT", nullable: true),
                    Neighborhood = table.Column<string>(type: "TEXT", nullable: true),
                    AddressLine = table.Column<string>(type: "TEXT", nullable: true),
                    LandArea = table.Column<double>(type: "REAL", nullable: true),
                    BuildingArea = table.Column<double>(type: "REAL", nullable: true),
                    UnitNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    YearRenovated = table.Column<int>(type: "INTEGER", nullable: true),
                    NearbyFacilities = table.Column<string>(type: "TEXT", nullable: true),
                    AmenitiesFa = table.Column<string>(type: "TEXT", nullable: true),
                    AmenitiesEn = table.Column<string>(type: "TEXT", nullable: true),
                    AmenitiesAr = table.Column<string>(type: "TEXT", nullable: true),
                    RegistrationTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ConstructionTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    HasParking = table.Column<bool>(type: "INTEGER", nullable: false),
                    ParkingCount = table.Column<int>(type: "INTEGER", nullable: true),
                    Deed = table.Column<string>(type: "TEXT", nullable: false),
                    ConstructionStatus = table.Column<string>(type: "TEXT", nullable: false),
                    HasPool = table.Column<bool>(type: "INTEGER", nullable: false),
                    PoolArea = table.Column<double>(type: "REAL", nullable: true),
                    TreeCount = table.Column<int>(type: "INTEGER", nullable: true),
                    HasElevator = table.Column<bool>(type: "INTEGER", nullable: false),
                    FloorCount = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentFa = table.Column<string>(type: "TEXT", nullable: false),
                    ContentEn = table.Column<string>(type: "TEXT", nullable: false),
                    ContentAr = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContentFa = table.Column<string>(type: "TEXT", nullable: false),
                    ContentEn = table.Column<string>(type: "TEXT", nullable: false),
                    ContentAr = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StaticDataGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Page = table.Column<string>(type: "TEXT", nullable: false),
                    Container = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaticDataGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HouseImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ImageAddress = table.Column<string>(type: "TEXT", nullable: false),
                    HouseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HouseImages_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "staticDatas",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    StringContentFa = table.Column<string>(type: "TEXT", nullable: true),
                    StringContentEn = table.Column<string>(type: "TEXT", nullable: true),
                    StringContentAr = table.Column<string>(type: "TEXT", nullable: true),
                    BestCountOfNumber = table.Column<int>(type: "INTEGER", nullable: true),
                    ImageAdress = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    GroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staticDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_staticDatas_StaticDataGroups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "StaticDataGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DownPayment = table.Column<decimal>(type: "TEXT", nullable: true),
                    MonthlyPayment = table.Column<decimal>(type: "TEXT", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    IsExchangeable = table.Column<bool>(type: "INTEGER", nullable: false),
                    HaveOffer = table.Column<bool>(type: "INTEGER", nullable: false),
                    FinalDownPayment = table.Column<decimal>(type: "TEXT", nullable: true),
                    FinalMonthlyPayment = table.Column<decimal>(type: "TEXT", nullable: true),
                    FinalTotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    DealTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deals_Statuses_DealTypeId",
                        column: x => x.DealTypeId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Area = table.Column<double>(type: "REAL", nullable: false),
                    RoomCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Capacity = table.Column<int>(type: "INTEGER", nullable: false),
                    HasBalcony = table.Column<bool>(type: "INTEGER", nullable: false),
                    BalconyArea = table.Column<double>(type: "REAL", nullable: true),
                    HasStorage = table.Column<bool>(type: "INTEGER", nullable: false),
                    StorageArea = table.Column<double>(type: "REAL", nullable: true),
                    ConstructionDirection = table.Column<string>(type: "TEXT", nullable: false),
                    CoolingStatus = table.Column<string>(type: "TEXT", nullable: false),
                    HeatingStatus = table.Column<string>(type: "TEXT", nullable: false),
                    HotWaterStatus = table.Column<string>(type: "TEXT", nullable: false),
                    ToiletTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    HouseId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Floors_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Floors_Statuses_ToiletTypeId",
                        column: x => x.ToiletTypeId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TitleFa = table.Column<string>(type: "TEXT", nullable: false),
                    TitleEn = table.Column<string>(type: "TEXT", nullable: false),
                    TitleAr = table.Column<string>(type: "TEXT", nullable: false),
                    DescriptionFa = table.Column<string>(type: "TEXT", nullable: false),
                    DescriptionEn = table.Column<string>(type: "TEXT", nullable: false),
                    DescriptionAr = table.Column<string>(type: "TEXT", nullable: false),
                    HouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    DealId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advertisements_Deals_DealId",
                        column: x => x.DealId,
                        principalTable: "Deals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advertisements_Houses_HouseId",
                        column: x => x.HouseId,
                        principalTable: "Houses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloorMaterials",
                columns: table => new
                {
                    FloorMaterialsId = table.Column<int>(type: "INTEGER", nullable: false),
                    FloorsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloorMaterials", x => new { x.FloorMaterialsId, x.FloorsId });
                    table.ForeignKey(
                        name: "FK_FloorMaterials_Floors_FloorsId",
                        column: x => x.FloorsId,
                        principalTable: "Floors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FloorMaterials_Materials_FloorMaterialsId",
                        column: x => x.FloorMaterialsId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertisementKeywords",
                columns: table => new
                {
                    AdvertisementsId = table.Column<int>(type: "INTEGER", nullable: false),
                    KeywordsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertisementKeywords", x => new { x.AdvertisementsId, x.KeywordsId });
                    table.ForeignKey(
                        name: "FK_AdvertisementKeywords_Advertisements_AdvertisementsId",
                        column: x => x.AdvertisementsId,
                        principalTable: "Advertisements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertisementKeywords_Keywords_KeywordsId",
                        column: x => x.KeywordsId,
                        principalTable: "Keywords",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvertisementKeywords_KeywordsId",
                table: "AdvertisementKeywords",
                column: "KeywordsId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_DealId",
                table: "Advertisements",
                column: "DealId");

            migrationBuilder.CreateIndex(
                name: "IX_Advertisements_HouseId",
                table: "Advertisements",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Deals_DealTypeId",
                table: "Deals",
                column: "DealTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FloorMaterials_FloorsId",
                table: "FloorMaterials",
                column: "FloorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_HouseId",
                table: "Floors",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_ToiletTypeId",
                table: "Floors",
                column: "ToiletTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HouseImages_HouseId",
                table: "HouseImages",
                column: "HouseId");

            migrationBuilder.CreateIndex(
                name: "IX_staticDatas_GroupId",
                table: "staticDatas",
                column: "GroupId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertisementKeywords");

            migrationBuilder.DropTable(
                name: "Agents");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "FloorMaterials");

            migrationBuilder.DropTable(
                name: "HouseImages");

            migrationBuilder.DropTable(
                name: "staticDatas");

            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "StaticDataGroups");

            migrationBuilder.DropTable(
                name: "Deals");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
