﻿// <auto-generated />
using System;
using CardDealer.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CardDealer.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220927152927_bridgetable")]
    partial class bridgetable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CardDealer.Entities.Models.Card", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Suit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasData(
                        new
                        {
                            Id = new Guid("067b0ce3-67bd-46b9-ba90-51f4ecc847d8"),
                            Suit = "Hearts",
                            Value = "Two"
                        },
                        new
                        {
                            Id = new Guid("2f8601e4-ded5-4a5c-9d2c-0668037ce7c4"),
                            Suit = "Hearts",
                            Value = "Three"
                        },
                        new
                        {
                            Id = new Guid("75537c6a-fab9-4166-9b70-18c3c2257ce2"),
                            Suit = "Hearts",
                            Value = "Four"
                        },
                        new
                        {
                            Id = new Guid("24d17dfd-37bb-40c5-9434-513a401b090d"),
                            Suit = "Hearts",
                            Value = "Five"
                        },
                        new
                        {
                            Id = new Guid("ca84a642-9be7-44f4-8a2a-1b4003992a74"),
                            Suit = "Hearts",
                            Value = "Six"
                        },
                        new
                        {
                            Id = new Guid("b45d599f-c156-4a54-84c1-d787210996d8"),
                            Suit = "Hearts",
                            Value = "Seven"
                        },
                        new
                        {
                            Id = new Guid("766d7c51-5a15-42b9-a79c-be0f5b8ebe2c"),
                            Suit = "Hearts",
                            Value = "Eight"
                        },
                        new
                        {
                            Id = new Guid("d4f04f36-1a5b-442a-b735-c3b910ab0926"),
                            Suit = "Hearts",
                            Value = "Nine"
                        },
                        new
                        {
                            Id = new Guid("685d0d1e-5231-48d5-8beb-0081c90a602f"),
                            Suit = "Hearts",
                            Value = "Ten"
                        },
                        new
                        {
                            Id = new Guid("602ee2f9-e8dd-43ae-810a-9c1c80eff64b"),
                            Suit = "Hearts",
                            Value = "Jack"
                        },
                        new
                        {
                            Id = new Guid("1bb8e985-2781-4787-86ca-769772a8547c"),
                            Suit = "Hearts",
                            Value = "Queen"
                        },
                        new
                        {
                            Id = new Guid("4b4603d2-f590-4367-b45f-1b1d54835d6c"),
                            Suit = "Hearts",
                            Value = "King"
                        },
                        new
                        {
                            Id = new Guid("9fd0151a-64d7-4286-a8a3-729e3dd6f8a7"),
                            Suit = "Hearts",
                            Value = "Ace"
                        },
                        new
                        {
                            Id = new Guid("1f714a09-f178-4376-9dde-32fb1066ddbd"),
                            Suit = "Diamonds",
                            Value = "Two"
                        },
                        new
                        {
                            Id = new Guid("5c8750d5-e71d-47cc-bd5e-02d33df33bc8"),
                            Suit = "Diamonds",
                            Value = "Three"
                        },
                        new
                        {
                            Id = new Guid("ba1f3c4c-711e-48aa-96cb-3a6c03c6076a"),
                            Suit = "Diamonds",
                            Value = "Four"
                        },
                        new
                        {
                            Id = new Guid("d44a7ac9-7d3b-4507-aa39-cabc363eebaf"),
                            Suit = "Diamonds",
                            Value = "Five"
                        },
                        new
                        {
                            Id = new Guid("082bb08c-38ca-4a9d-8c58-253bd7f47280"),
                            Suit = "Diamonds",
                            Value = "Six"
                        },
                        new
                        {
                            Id = new Guid("7366f187-977f-4290-a012-f6acad617245"),
                            Suit = "Diamonds",
                            Value = "Seven"
                        },
                        new
                        {
                            Id = new Guid("b30956fc-9c49-4c93-9e23-abb207a4476b"),
                            Suit = "Diamonds",
                            Value = "Eight"
                        },
                        new
                        {
                            Id = new Guid("394e44eb-4a13-44d5-95d1-6f6189f6e0f0"),
                            Suit = "Diamonds",
                            Value = "Nine"
                        },
                        new
                        {
                            Id = new Guid("ccfc6096-80c8-4a72-8bc5-244015551cdd"),
                            Suit = "Diamonds",
                            Value = "Ten"
                        },
                        new
                        {
                            Id = new Guid("06411a1b-199f-46dc-9497-c0482f53ef1e"),
                            Suit = "Diamonds",
                            Value = "Jack"
                        },
                        new
                        {
                            Id = new Guid("6ac0bc66-a545-450c-9dc0-d325b9566765"),
                            Suit = "Diamonds",
                            Value = "Queen"
                        },
                        new
                        {
                            Id = new Guid("3adb4575-1ffc-4c9a-a57f-ec0236b1029d"),
                            Suit = "Diamonds",
                            Value = "King"
                        },
                        new
                        {
                            Id = new Guid("1bc3210c-16c9-4633-b485-c2482d18d37f"),
                            Suit = "Diamonds",
                            Value = "Ace"
                        },
                        new
                        {
                            Id = new Guid("42df3bad-dec8-4a90-a3ca-e863418dcffa"),
                            Suit = "Clubs",
                            Value = "Two"
                        },
                        new
                        {
                            Id = new Guid("94c6f450-3868-4952-9ac5-e29e42dea2db"),
                            Suit = "Clubs",
                            Value = "Three"
                        },
                        new
                        {
                            Id = new Guid("d4e2504e-2771-41a0-93ac-810803a818c0"),
                            Suit = "Clubs",
                            Value = "Four"
                        },
                        new
                        {
                            Id = new Guid("c29dbab0-377b-4d0c-a2d0-95e378a47c4f"),
                            Suit = "Clubs",
                            Value = "Five"
                        },
                        new
                        {
                            Id = new Guid("2b307c67-24ed-4bd7-be04-743e013801d6"),
                            Suit = "Clubs",
                            Value = "Six"
                        },
                        new
                        {
                            Id = new Guid("5025fade-c879-401c-a53f-2d8fe5bf4908"),
                            Suit = "Clubs",
                            Value = "Seven"
                        },
                        new
                        {
                            Id = new Guid("0a986e00-efb8-4799-b708-c548d7ce6af8"),
                            Suit = "Clubs",
                            Value = "Eight"
                        },
                        new
                        {
                            Id = new Guid("6cb1b436-18e6-4edc-a8dd-7ac923a95652"),
                            Suit = "Clubs",
                            Value = "Nine"
                        },
                        new
                        {
                            Id = new Guid("84ac515d-8497-47a1-8bdd-dd9712d08b4d"),
                            Suit = "Clubs",
                            Value = "Ten"
                        },
                        new
                        {
                            Id = new Guid("f75e66b2-ce79-4d02-a697-ceb870734cd3"),
                            Suit = "Clubs",
                            Value = "Jack"
                        },
                        new
                        {
                            Id = new Guid("d0c20bd8-cbfd-4883-9857-580ade9df31f"),
                            Suit = "Clubs",
                            Value = "Queen"
                        },
                        new
                        {
                            Id = new Guid("cd311be8-888a-457a-8654-47f284a34dc6"),
                            Suit = "Clubs",
                            Value = "King"
                        },
                        new
                        {
                            Id = new Guid("80636ce3-9eec-4583-b803-be69e4abbb87"),
                            Suit = "Clubs",
                            Value = "Ace"
                        },
                        new
                        {
                            Id = new Guid("79f306f2-4fd8-438d-8412-d6537578fc23"),
                            Suit = "Spades",
                            Value = "Two"
                        },
                        new
                        {
                            Id = new Guid("35dd267b-a630-4fd2-9898-c28dce5176fc"),
                            Suit = "Spades",
                            Value = "Three"
                        },
                        new
                        {
                            Id = new Guid("a32ac69e-7769-4de1-b599-8781fe104fe2"),
                            Suit = "Spades",
                            Value = "Four"
                        },
                        new
                        {
                            Id = new Guid("f0d14ce6-e431-42cc-ac33-82dce01109df"),
                            Suit = "Spades",
                            Value = "Five"
                        },
                        new
                        {
                            Id = new Guid("1033ee5e-193f-40cd-9b93-6f34c5a8fb7c"),
                            Suit = "Spades",
                            Value = "Six"
                        },
                        new
                        {
                            Id = new Guid("eaf2c565-3365-45e7-a9b4-b12f44908b19"),
                            Suit = "Spades",
                            Value = "Seven"
                        },
                        new
                        {
                            Id = new Guid("cd0ed379-31ce-4bdf-96f3-9a5e5c33db05"),
                            Suit = "Spades",
                            Value = "Eight"
                        },
                        new
                        {
                            Id = new Guid("ba3301df-ca9a-44f5-b1aa-e09bc8135b39"),
                            Suit = "Spades",
                            Value = "Nine"
                        },
                        new
                        {
                            Id = new Guid("c39bab68-1844-4d74-89f1-033a5d815882"),
                            Suit = "Spades",
                            Value = "Ten"
                        },
                        new
                        {
                            Id = new Guid("f9cf6b4a-072d-492d-911c-e6c12a0c13f6"),
                            Suit = "Spades",
                            Value = "Jack"
                        },
                        new
                        {
                            Id = new Guid("8656a945-1f34-436f-8db3-3e6bf48a8c61"),
                            Suit = "Spades",
                            Value = "Queen"
                        },
                        new
                        {
                            Id = new Guid("0f9281ba-2394-49fc-8f10-b0df1a7e12a3"),
                            Suit = "Spades",
                            Value = "King"
                        },
                        new
                        {
                            Id = new Guid("5da0047c-0e80-411b-b699-63735acf377e"),
                            Suit = "Spades",
                            Value = "Ace"
                        });
                });

            modelBuilder.Entity("CardDealer.Entities.Models.CardHand", b =>
                {
                    b.Property<Guid>("HandId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CardId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("HandId", "CardId");

                    b.HasIndex("CardId");

                    b.ToTable("CardHands");
                });

            modelBuilder.Entity("CardDealer.Entities.Models.Hand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Hands");
                });

            modelBuilder.Entity("CardDealer.Entities.Models.CardHand", b =>
                {
                    b.HasOne("CardDealer.Entities.Models.Card", "Card")
                        .WithMany("CardHands")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CardDealer.Entities.Models.Hand", "Hand")
                        .WithMany("CardHands")
                        .HasForeignKey("HandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Hand");
                });

            modelBuilder.Entity("CardDealer.Entities.Models.Card", b =>
                {
                    b.Navigation("CardHands");
                });

            modelBuilder.Entity("CardDealer.Entities.Models.Hand", b =>
                {
                    b.Navigation("CardHands");
                });
#pragma warning restore 612, 618
        }
    }
}
