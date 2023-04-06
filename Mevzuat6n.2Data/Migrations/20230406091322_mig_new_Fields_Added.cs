using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mevzuat6n._2Data.Migrations
{
    public partial class mig_new_Fields_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("115bef82-9bdd-4526-821c-1faf64409695"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e37db5d3-a1a6-4bc1-b746-7fa59ce23929"));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyStady",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KeyWords",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "About",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MevzuatNo",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MevzuatTipi",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RgSayi",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RgTarihi",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SonlanmaTarihi",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VersionNo",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "YururlukTarihi",
                table: "Articles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "About", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "MevzuatNo", "MevzuatTipi", "ModifiedBy", "ModifiedDate", "RgSayi", "RgTarihi", "SonlanmaTarihi", "Title", "UserId", "VersionNo", "ViewCount", "YururlukTarihi" },
                values: new object[,]
                {
                    { new Guid("4926979e-f02f-4dc2-a451-236941416b1a"), null, new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(952), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, null, null, null, null, null, "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), null, 15, null },
                    { new Guid("7550d451-f04a-46fd-b00e-0bf526e504ef"), null, new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(942), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, null, null, null, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), null, 15, null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "aff20b0c-10cb-4c0c-9371-baab1d7f044a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "c9089c73-9860-482b-b546-9f5fc37dd204");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "eec3c325-89ce-4cd5-8e07-7421755f02e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6493169-8901-4f2f-b557-5f691152cda1", "AQAAAAEAACcQAAAAEIOxJ7a/Ya9qnclg/hSzaleziLxUlVx7aLEUZYXv6MHMDyJ71ghQ40MmP/x7iOQ1bA==", "222ec12c-7f90-4606-80fc-af9061d29f73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9858ea63-0c95-47b5-bd13-df41f9d35865", "AQAAAAEAACcQAAAAEHibtUMA3DVYFfm5HX8qb5psz6jiMcyBn5cwBFqdVEZqxMIZYJMgY/bZpGx3UtRQbg==", "9ff402d4-f883-41f5-a780-f2a74eca7770" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 6, 12, 13, 21, 652, DateTimeKind.Local).AddTicks(3191));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4926979e-f02f-4dc2-a451-236941416b1a"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7550d451-f04a-46fd-b00e-0bf526e504ef"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "KeyStady",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "KeyWords",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "About",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "MevzuatNo",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "MevzuatTipi",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "RgSayi",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "RgTarihi",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "SonlanmaTarihi",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "VersionNo",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "YururlukTarihi",
                table: "Articles");

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("115bef82-9bdd-4526-821c-1faf64409695"), new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"), "Visual Studio Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(1427), null, null, new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"), false, null, null, "Visual Studio Deneme Makalesi 1", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"), 15 },
                    { new Guid("e37db5d3-a1a6-4bc1-b746-7fa59ce23929"), new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"), "Asp.net Core Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Vivamus suscipit tortor eget felis porttitor volutpat. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi. Sed porttitor lectus nibh. Nulla porttitor accumsan tincidunt. Proin eget tortor risus. Donec rutrum congue leo eget malesuada. Curabitur non nulla sit amet nisl tempus convallis quis ac lectus. Sed porttitor lectus nibh. Curabitur aliquet quam id dui posuere blandit. Mauris blandit aliquet elit, eget tincidunt nibh pulvinar a. Curabitur aliquet quam id dui posuere blandit. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla porttitor accumsan tincidunt. Pellentesque in ipsum id orci porta dapibus. Vivamus magna justo, lacinia eget consectetur sed, convallis at tellus. Praesent sapien massa, convallis a pellentesque nec, egestas non nisi.", "Admin Test", new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(1418), null, null, new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("16ea936c-7a28-4c30-86a2-9a9704b6115e"),
                column: "ConcurrencyStamp",
                value: "53d8df9a-e156-4a17-9134-4ab3087181c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7cb750cf-3612-4fb4-9f7d-a38ba8f16bf4"),
                column: "ConcurrencyStamp",
                value: "6dbff4c7-343e-4a43-a846-418672703d13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("edf6c246-41d8-475f-8d92-41dddac3aefb"),
                column: "ConcurrencyStamp",
                value: "77433a35-b356-49d3-aa4f-05434fb145aa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "734b5297-f5e5-4aca-9c0f-d258259b3606", "AQAAAAEAACcQAAAAEIt4c+tSYv33foAqZv3ar2D6LAIfi0s7qC9haz6XdmZyxi0soTb+HfSpmm3eL2fdYQ==", "7271a862-61b0-44da-a46c-d4a9b008bc6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64ef1294-c226-41ab-9143-9f21e604f8bf", "AQAAAAEAACcQAAAAEH4fgX7+Q9di2d1z/dfYdgWzPq5Bp9jp2kukNVlWCGKvvLSU6o4NZbFyFuliu2LtTg==", "b46d944c-849c-438b-8db9-40b6b385d81a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4c569a9a-5f41-478f-9d17-69ac5b02ae0b"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d23e4f79-9600-4b5e-b3e9-756cdcacd2b1"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("d16a6ec7-8c50-4ab0-89a5-02b9a551f0fa"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f71f4b9a-aa60-461d-b398-de31001bf214"),
                column: "CreatedDate",
                value: new DateTime(2023, 4, 2, 10, 4, 6, 904, DateTimeKind.Local).AddTicks(3770));
        }
    }
}
