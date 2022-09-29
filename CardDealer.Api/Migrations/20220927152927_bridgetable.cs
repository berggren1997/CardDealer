using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardDealer.Api.Migrations
{
    public partial class bridgetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardHand");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("11fedebf-cc85-453e-a94e-4714dc35eaf9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("15eef474-b429-4bc7-96ea-5bef2723f236"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1b296fec-ff31-4bdc-9b30-6dfd598c5678"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1b354afe-1c0f-4dca-9a37-62fcfd187881"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1f9454e5-184b-4b50-8558-79eb28246817"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2248a359-b28a-4220-a5f1-ad818d441a12"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2324453b-a7e1-498d-9709-167362b84f92"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("240c0d2b-c12f-435f-8a9a-c457d95186ca"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2616076f-87b7-4afe-86bd-47144b52369a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("283b6bcf-cfa3-47a5-bee9-695b2e89ec85"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2941ef8a-f6cb-4170-9ea1-73ed82b526e2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2ad1eff7-4288-4044-aa3f-f66c65016110"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2b72262e-07d5-4dca-86f0-8bcfe0bf5f20"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2be855cc-12c2-4289-b0a1-2f0085ded079"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("352865be-2aa5-45ca-9a84-8f122c6d2038"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("359ae769-d6c3-416c-8c56-ec9cea601978"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("40ed4973-b716-49c7-b64b-7d2b364b8652"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("421ce75d-1c92-4c6d-90ca-bf544f9535a2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("47616579-8831-49f0-8cf8-fcef4aed52b0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("49e3124c-2991-40ea-832b-593f97f0190d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4a68f5ec-3a90-40af-9ee8-c732012f969c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4c627e17-b83f-4e36-89ab-140678d4b2f3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4c8b0f22-cdda-4b03-99ee-01b85892cb5c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4de9c913-2575-4598-ae1b-2cd2716b8aa2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4e83609e-5388-4f83-8d34-01a8ff3bd711"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("576834a8-ba5e-4b74-b932-74a5351cfdb1"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5f44ca1f-7c96-41f2-9396-5774bf13db9b"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("661fb046-f6d1-4a2c-adf2-4cfe27737f9d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("6fb8a89b-6c2e-49a4-a713-912bede12d65"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("728d4e4c-6e9c-468e-89ae-eb94f1e45f3f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7f4be3ed-281a-48f4-a2c9-72b5ca7bdff8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7fcfead0-4aad-43dc-bb9d-29003e9e3b88"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8ab4f657-fec7-4e6f-a313-bc48714ea812"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("96439203-188d-45a4-981b-1b1ca4cc3ac7"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a3265680-1817-4728-bde0-dfaac3446d41"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("aa642858-84ae-42a0-a669-cca4ba1b0dcb"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b00bb6da-91b1-455b-baac-004a27174bd3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b1ac65fd-7883-4f96-8dd2-0af122ad1e5d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b3572929-7e6b-4110-965f-ea01233b2492"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b36c1ff1-1620-4cbf-b609-691f322e360f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b3b5cee7-7056-45c8-ae57-ab85b988d5f5"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("bbf77ef9-d458-476c-a17e-c24b2f744bb9"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c0c19b50-30f3-4200-8438-45288efe36c0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d2e1236b-21e4-46e4-a87f-223a1ffcafb3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d38d9e8d-13bb-4de1-8ee4-5553f3048938"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("e7c5ab7b-b88f-4597-b26b-f03eb41525f4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ee776d52-af07-43bb-a1bd-db7394003712"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("fcebafef-db36-4086-863b-e0286dffa42a"));

            migrationBuilder.CreateTable(
                name: "CardHands",
                columns: table => new
                {
                    HandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardHands", x => new { x.HandId, x.CardId });
                    table.ForeignKey(
                        name: "FK_CardHands_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CardHands_Hands_HandId",
                        column: x => x.HandId,
                        principalTable: "Hands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Suit", "Value" },
                values: new object[,]
                {
                    { new Guid("06411a1b-199f-46dc-9497-c0482f53ef1e"), "Diamonds", "Jack" },
                    { new Guid("067b0ce3-67bd-46b9-ba90-51f4ecc847d8"), "Hearts", "Two" },
                    { new Guid("082bb08c-38ca-4a9d-8c58-253bd7f47280"), "Diamonds", "Six" },
                    { new Guid("0a986e00-efb8-4799-b708-c548d7ce6af8"), "Clubs", "Eight" },
                    { new Guid("0f9281ba-2394-49fc-8f10-b0df1a7e12a3"), "Spades", "King" },
                    { new Guid("1033ee5e-193f-40cd-9b93-6f34c5a8fb7c"), "Spades", "Six" },
                    { new Guid("1bb8e985-2781-4787-86ca-769772a8547c"), "Hearts", "Queen" },
                    { new Guid("1bc3210c-16c9-4633-b485-c2482d18d37f"), "Diamonds", "Ace" },
                    { new Guid("1f714a09-f178-4376-9dde-32fb1066ddbd"), "Diamonds", "Two" },
                    { new Guid("24d17dfd-37bb-40c5-9434-513a401b090d"), "Hearts", "Five" },
                    { new Guid("2b307c67-24ed-4bd7-be04-743e013801d6"), "Clubs", "Six" },
                    { new Guid("2f8601e4-ded5-4a5c-9d2c-0668037ce7c4"), "Hearts", "Three" },
                    { new Guid("35dd267b-a630-4fd2-9898-c28dce5176fc"), "Spades", "Three" },
                    { new Guid("394e44eb-4a13-44d5-95d1-6f6189f6e0f0"), "Diamonds", "Nine" },
                    { new Guid("3adb4575-1ffc-4c9a-a57f-ec0236b1029d"), "Diamonds", "King" },
                    { new Guid("42df3bad-dec8-4a90-a3ca-e863418dcffa"), "Clubs", "Two" },
                    { new Guid("4b4603d2-f590-4367-b45f-1b1d54835d6c"), "Hearts", "King" },
                    { new Guid("5025fade-c879-401c-a53f-2d8fe5bf4908"), "Clubs", "Seven" },
                    { new Guid("5c8750d5-e71d-47cc-bd5e-02d33df33bc8"), "Diamonds", "Three" },
                    { new Guid("5da0047c-0e80-411b-b699-63735acf377e"), "Spades", "Ace" },
                    { new Guid("602ee2f9-e8dd-43ae-810a-9c1c80eff64b"), "Hearts", "Jack" },
                    { new Guid("685d0d1e-5231-48d5-8beb-0081c90a602f"), "Hearts", "Ten" },
                    { new Guid("6ac0bc66-a545-450c-9dc0-d325b9566765"), "Diamonds", "Queen" },
                    { new Guid("6cb1b436-18e6-4edc-a8dd-7ac923a95652"), "Clubs", "Nine" },
                    { new Guid("7366f187-977f-4290-a012-f6acad617245"), "Diamonds", "Seven" },
                    { new Guid("75537c6a-fab9-4166-9b70-18c3c2257ce2"), "Hearts", "Four" },
                    { new Guid("766d7c51-5a15-42b9-a79c-be0f5b8ebe2c"), "Hearts", "Eight" },
                    { new Guid("79f306f2-4fd8-438d-8412-d6537578fc23"), "Spades", "Two" },
                    { new Guid("80636ce3-9eec-4583-b803-be69e4abbb87"), "Clubs", "Ace" },
                    { new Guid("84ac515d-8497-47a1-8bdd-dd9712d08b4d"), "Clubs", "Ten" },
                    { new Guid("8656a945-1f34-436f-8db3-3e6bf48a8c61"), "Spades", "Queen" },
                    { new Guid("94c6f450-3868-4952-9ac5-e29e42dea2db"), "Clubs", "Three" },
                    { new Guid("9fd0151a-64d7-4286-a8a3-729e3dd6f8a7"), "Hearts", "Ace" },
                    { new Guid("a32ac69e-7769-4de1-b599-8781fe104fe2"), "Spades", "Four" },
                    { new Guid("b30956fc-9c49-4c93-9e23-abb207a4476b"), "Diamonds", "Eight" },
                    { new Guid("b45d599f-c156-4a54-84c1-d787210996d8"), "Hearts", "Seven" },
                    { new Guid("ba1f3c4c-711e-48aa-96cb-3a6c03c6076a"), "Diamonds", "Four" },
                    { new Guid("ba3301df-ca9a-44f5-b1aa-e09bc8135b39"), "Spades", "Nine" },
                    { new Guid("c29dbab0-377b-4d0c-a2d0-95e378a47c4f"), "Clubs", "Five" },
                    { new Guid("c39bab68-1844-4d74-89f1-033a5d815882"), "Spades", "Ten" },
                    { new Guid("ca84a642-9be7-44f4-8a2a-1b4003992a74"), "Hearts", "Six" },
                    { new Guid("ccfc6096-80c8-4a72-8bc5-244015551cdd"), "Diamonds", "Ten" }
                });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "Suit", "Value" },
                values: new object[,]
                {
                    { new Guid("cd0ed379-31ce-4bdf-96f3-9a5e5c33db05"), "Spades", "Eight" },
                    { new Guid("cd311be8-888a-457a-8654-47f284a34dc6"), "Clubs", "King" },
                    { new Guid("d0c20bd8-cbfd-4883-9857-580ade9df31f"), "Clubs", "Queen" },
                    { new Guid("d44a7ac9-7d3b-4507-aa39-cabc363eebaf"), "Diamonds", "Five" },
                    { new Guid("d4e2504e-2771-41a0-93ac-810803a818c0"), "Clubs", "Four" },
                    { new Guid("d4f04f36-1a5b-442a-b735-c3b910ab0926"), "Hearts", "Nine" },
                    { new Guid("eaf2c565-3365-45e7-a9b4-b12f44908b19"), "Spades", "Seven" },
                    { new Guid("f0d14ce6-e431-42cc-ac33-82dce01109df"), "Spades", "Five" },
                    { new Guid("f75e66b2-ce79-4d02-a697-ceb870734cd3"), "Clubs", "Jack" },
                    { new Guid("f9cf6b4a-072d-492d-911c-e6c12a0c13f6"), "Spades", "Jack" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardHands_CardId",
                table: "CardHands",
                column: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardHands");

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("06411a1b-199f-46dc-9497-c0482f53ef1e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("067b0ce3-67bd-46b9-ba90-51f4ecc847d8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("082bb08c-38ca-4a9d-8c58-253bd7f47280"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0a986e00-efb8-4799-b708-c548d7ce6af8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("0f9281ba-2394-49fc-8f10-b0df1a7e12a3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1033ee5e-193f-40cd-9b93-6f34c5a8fb7c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1bb8e985-2781-4787-86ca-769772a8547c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1bc3210c-16c9-4633-b485-c2482d18d37f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("1f714a09-f178-4376-9dde-32fb1066ddbd"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("24d17dfd-37bb-40c5-9434-513a401b090d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2b307c67-24ed-4bd7-be04-743e013801d6"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("2f8601e4-ded5-4a5c-9d2c-0668037ce7c4"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("35dd267b-a630-4fd2-9898-c28dce5176fc"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("394e44eb-4a13-44d5-95d1-6f6189f6e0f0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("3adb4575-1ffc-4c9a-a57f-ec0236b1029d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("42df3bad-dec8-4a90-a3ca-e863418dcffa"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("4b4603d2-f590-4367-b45f-1b1d54835d6c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5025fade-c879-401c-a53f-2d8fe5bf4908"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5c8750d5-e71d-47cc-bd5e-02d33df33bc8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("5da0047c-0e80-411b-b699-63735acf377e"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("602ee2f9-e8dd-43ae-810a-9c1c80eff64b"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("685d0d1e-5231-48d5-8beb-0081c90a602f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("6ac0bc66-a545-450c-9dc0-d325b9566765"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("6cb1b436-18e6-4edc-a8dd-7ac923a95652"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("7366f187-977f-4290-a012-f6acad617245"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("75537c6a-fab9-4166-9b70-18c3c2257ce2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("766d7c51-5a15-42b9-a79c-be0f5b8ebe2c"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("79f306f2-4fd8-438d-8412-d6537578fc23"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("80636ce3-9eec-4583-b803-be69e4abbb87"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("84ac515d-8497-47a1-8bdd-dd9712d08b4d"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("8656a945-1f34-436f-8db3-3e6bf48a8c61"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("94c6f450-3868-4952-9ac5-e29e42dea2db"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("9fd0151a-64d7-4286-a8a3-729e3dd6f8a7"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("a32ac69e-7769-4de1-b599-8781fe104fe2"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b30956fc-9c49-4c93-9e23-abb207a4476b"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("b45d599f-c156-4a54-84c1-d787210996d8"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ba1f3c4c-711e-48aa-96cb-3a6c03c6076a"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ba3301df-ca9a-44f5-b1aa-e09bc8135b39"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c29dbab0-377b-4d0c-a2d0-95e378a47c4f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("c39bab68-1844-4d74-89f1-033a5d815882"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ca84a642-9be7-44f4-8a2a-1b4003992a74"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("ccfc6096-80c8-4a72-8bc5-244015551cdd"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("cd0ed379-31ce-4bdf-96f3-9a5e5c33db05"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("cd311be8-888a-457a-8654-47f284a34dc6"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d0c20bd8-cbfd-4883-9857-580ade9df31f"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d44a7ac9-7d3b-4507-aa39-cabc363eebaf"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d4e2504e-2771-41a0-93ac-810803a818c0"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("d4f04f36-1a5b-442a-b735-c3b910ab0926"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("eaf2c565-3365-45e7-a9b4-b12f44908b19"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f0d14ce6-e431-42cc-ac33-82dce01109df"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f75e66b2-ce79-4d02-a697-ceb870734cd3"));

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: new Guid("f9cf6b4a-072d-492d-911c-e6c12a0c13f6"));

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
    }
}
