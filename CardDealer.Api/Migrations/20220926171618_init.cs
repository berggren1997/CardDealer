using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDealer.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Suit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hands",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardHand",
                columns: table => new
                {
                    CardHandsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHand", x => new { x.CardHandsId, x.CardsId });
                    table.ForeignKey(
                        name: "FK_CardHand_Cards_CardsId",
                        column: x => x.CardsId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardHand_Hands_CardHandsId",
                        column: x => x.CardHandsId,
                        principalTable: "Hands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Suit", "Value" },
                values: new object[,]
                {
                    { new Guid("11fedebf-cc85-453e-a94e-4714dc35eaf9"), "Diamonds", "King" },
                    { new Guid("15eef474-b429-4bc7-96ea-5bef2723f236"), "Diamonds", "Two" },
                    { new Guid("1b296fec-ff31-4bdc-9b30-6dfd598c5678"), "Diamonds", "Nine" },
                    { new Guid("1b354afe-1c0f-4dca-9a37-62fcfd187881"), "Clubs", "Three" },
                    { new Guid("1f9454e5-184b-4b50-8558-79eb28246817"), "Clubs", "Nine" },
                    { new Guid("2248a359-b28a-4220-a5f1-ad818d441a12"), "Diamonds", "Seven" },
                    { new Guid("2324453b-a7e1-498d-9709-167362b84f92"), "Clubs", "Jack" },
                    { new Guid("240c0d2b-c12f-435f-8a9a-c457d95186ca"), "Spades", "Six" },
                    { new Guid("2616076f-87b7-4afe-86bd-47144b52369a"), "Hearts", "King" },
                    { new Guid("283b6bcf-cfa3-47a5-bee9-695b2e89ec85"), "Clubs", "Seven" },
                    { new Guid("2941ef8a-f6cb-4170-9ea1-73ed82b526e2"), "Clubs", "Queen" },
                    { new Guid("2ad1eff7-4288-4044-aa3f-f66c65016110"), "Hearts", "Three" },
                    { new Guid("2b72262e-07d5-4dca-86f0-8bcfe0bf5f20"), "Clubs", "Ten" },
                    { new Guid("2be855cc-12c2-4289-b0a1-2f0085ded079"), "Hearts", "Jack" },
                    { new Guid("352865be-2aa5-45ca-9a84-8f122c6d2038"), "Clubs", "Five" },
                    { new Guid("359ae769-d6c3-416c-8c56-ec9cea601978"), "Clubs", "Two" },
                    { new Guid("40ed4973-b716-49c7-b64b-7d2b364b8652"), "Clubs", "King" },
                    { new Guid("421ce75d-1c92-4c6d-90ca-bf544f9535a2"), "Diamonds", "Ten" },
                    { new Guid("47616579-8831-49f0-8cf8-fcef4aed52b0"), "Spades", "Queen" },
                    { new Guid("49e3124c-2991-40ea-832b-593f97f0190d"), "Clubs", "Eight" },
                    { new Guid("4a68f5ec-3a90-40af-9ee8-c732012f969c"), "Clubs", "Six" },
                    { new Guid("4c627e17-b83f-4e36-89ab-140678d4b2f3"), "Hearts", "Queen" },
                    { new Guid("4c8b0f22-cdda-4b03-99ee-01b85892cb5c"), "Hearts", "Six" },
                    { new Guid("4de9c913-2575-4598-ae1b-2cd2716b8aa2"), "Spades", "Jack" },
                    { new Guid("4e83609e-5388-4f83-8d34-01a8ff3bd711"), "Hearts", "Five" },
                    { new Guid("576834a8-ba5e-4b74-b932-74a5351cfdb1"), "Spades", "Two" },
                    { new Guid("5f44ca1f-7c96-41f2-9396-5774bf13db9b"), "Spades", "Eight" },
                    { new Guid("661fb046-f6d1-4a2c-adf2-4cfe27737f9d"), "Spades", "Seven" },
                    { new Guid("6fb8a89b-6c2e-49a4-a713-912bede12d65"), "Hearts", "Seven" },
                    { new Guid("728d4e4c-6e9c-468e-89ae-eb94f1e45f3f"), "Hearts", "Two" },
                    { new Guid("7f4be3ed-281a-48f4-a2c9-72b5ca7bdff8"), "Spades", "Ten" },
                    { new Guid("7fcfead0-4aad-43dc-bb9d-29003e9e3b88"), "Diamonds", "Queen" },
                    { new Guid("8ab4f657-fec7-4e6f-a313-bc48714ea812"), "Diamonds", "Jack" },
                    { new Guid("96439203-188d-45a4-981b-1b1ca4cc3ac7"), "Clubs", "Four" },
                    { new Guid("a3265680-1817-4728-bde0-dfaac3446d41"), "Diamonds", "Three" },
                    { new Guid("aa642858-84ae-42a0-a669-cca4ba1b0dcb"), "Diamonds", "Eight" },
                    { new Guid("b00bb6da-91b1-455b-baac-004a27174bd3"), "Hearts", "Four" },
                    { new Guid("b1ac65fd-7883-4f96-8dd2-0af122ad1e5d"), "Hearts", "Eight" },
                    { new Guid("b3572929-7e6b-4110-965f-ea01233b2492"), "Spades", "Five" },
                    { new Guid("b36c1ff1-1620-4cbf-b609-691f322e360f"), "Diamonds", "Four" },
                    { new Guid("b3b5cee7-7056-45c8-ae57-ab85b988d5f5"), "Hearts", "Nine" },
                    { new Guid("bbf77ef9-d458-476c-a17e-c24b2f744bb9"), "Spades", "Four" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Suit", "Value" },
                values: new object[,]
                {
                    { new Guid("c0c19b50-30f3-4200-8438-45288efe36c0"), "Spades", "Three" },
                    { new Guid("d2e1236b-21e4-46e4-a87f-223a1ffcafb3"), "Diamonds", "Six" },
                    { new Guid("d38d9e8d-13bb-4de1-8ee4-5553f3048938"), "Diamonds", "Five" },
                    { new Guid("e7c5ab7b-b88f-4597-b26b-f03eb41525f4"), "Hearts", "Ten" },
                    { new Guid("ee776d52-af07-43bb-a1bd-db7394003712"), "Spades", "Nine" },
                    { new Guid("fcebafef-db36-4086-863b-e0286dffa42a"), "Spades", "King" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardHand_CardsId",
                table: "CardHand",
                column: "CardsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardHand");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "Hands");
        }
    }
}
