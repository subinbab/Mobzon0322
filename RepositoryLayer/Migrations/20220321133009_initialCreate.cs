using Microsoft.EntityFrameworkCore.Migrations;

namespace RepositoryLayer.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "colors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productBrands",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productBrands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productCam",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    primaryCam = table.Column<int>(type: "int", nullable: false),
                    secondaryCam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productCam", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ProductOsFeatures",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    operatingSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    processor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    processorCore = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOsFeatures", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productSimTypes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productSimTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ram",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ram = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ram", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "storages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_storages", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    simTypeId = table.Column<int>(type: "int", nullable: false),
                    brandId = table.Column<int>(type: "int", nullable: false),
                    osProcessorId = table.Column<int>(type: "int", nullable: false),
                    osFeaturesid = table.Column<int>(type: "int", nullable: true),
                    camFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.ForeignKey(
                        name: "FK_products_productBrands_brandId",
                        column: x => x.brandId,
                        principalTable: "productBrands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_productCam_camFeaturesId",
                        column: x => x.camFeaturesId,
                        principalTable: "productCam",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_ProductOsFeatures_osFeaturesid",
                        column: x => x.osFeaturesid,
                        principalTable: "ProductOsFeatures",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_products_productSimTypes_simTypeId",
                        column: x => x.simTypeId,
                        principalTable: "productSimTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_types_typeId",
                        column: x => x.typeId,
                        principalTable: "types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    imagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.id);
                    table.ForeignKey(
                        name: "FK_images_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productColors",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    colorsId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productColors", x => x.id);
                    table.ForeignKey(
                        name: "FK_productColors_colors_colorsId",
                        column: x => x.colorsId,
                        principalTable: "colors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productColors_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "productRams",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ramId = table.Column<int>(type: "int", nullable: false),
                    ramsid = table.Column<int>(type: "int", nullable: true),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productRams", x => x.id);
                    table.ForeignKey(
                        name: "FK_productRams_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productRams_ram_ramsid",
                        column: x => x.ramsid,
                        principalTable: "ram",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "productStorages",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storageId = table.Column<int>(type: "int", nullable: false),
                    productId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productStorages", x => x.id);
                    table.ForeignKey(
                        name: "FK_productStorages_products_productId",
                        column: x => x.productId,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productStorages_storages_storageId",
                        column: x => x.storageId,
                        principalTable: "storages",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_images_productId",
                table: "images",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productColors_colorsId",
                table: "productColors",
                column: "colorsId");

            migrationBuilder.CreateIndex(
                name: "IX_productColors_productId",
                table: "productColors",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productRams_productId",
                table: "productRams",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productRams_ramsid",
                table: "productRams",
                column: "ramsid");

            migrationBuilder.CreateIndex(
                name: "IX_products_brandId",
                table: "products",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_products_camFeaturesId",
                table: "products",
                column: "camFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_products_osFeaturesid",
                table: "products",
                column: "osFeaturesid");

            migrationBuilder.CreateIndex(
                name: "IX_products_simTypeId",
                table: "products",
                column: "simTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_products_typeId",
                table: "products",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_productStorages_productId",
                table: "productStorages",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_productStorages_storageId",
                table: "productStorages",
                column: "storageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "productColors");

            migrationBuilder.DropTable(
                name: "productRams");

            migrationBuilder.DropTable(
                name: "productStorages");

            migrationBuilder.DropTable(
                name: "colors");

            migrationBuilder.DropTable(
                name: "ram");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "storages");

            migrationBuilder.DropTable(
                name: "productBrands");

            migrationBuilder.DropTable(
                name: "productCam");

            migrationBuilder.DropTable(
                name: "ProductOsFeatures");

            migrationBuilder.DropTable(
                name: "productSimTypes");

            migrationBuilder.DropTable(
                name: "types");
        }
    }
}
