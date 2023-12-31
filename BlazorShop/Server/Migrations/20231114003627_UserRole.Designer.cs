﻿// <auto-generated />
using System;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231114003627_UserRole")]
    partial class UserRole
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorShop.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BlazorShop.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("BlazorShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Games",
                            Url = "games"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BlazorShop.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            Description = "Elden Ring is a 2022 action role-playing game developed by FromSoftware. It was directed by Hidetaka Miyazaki with worldbuilding provided by fantasy writer George R. R. Martin. It was released for PlayStation 4, PlayStation 5, Windows, Xbox One, and Xbox Series X/S on February 25 by FromSoftware in Japan and Bandai Namco Entertainment internationally. Players control a customizable player character who is on a quest to repair the Elden Ring and become the new Elden Lord.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg",
                            Title = "Elden Ring"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "Hollow Knight is a 2017 Metroidvania video game developed and published by independent developer Team Cherry. In the game, the player controls the Knight, a nameless insectoid warrior, who explores Hallownest, a fallen kingdom plagued by a supernatural disease, known as the infection. The game is set in diverse subterranean locations, featuring friendly and hostile insectoid characters and numerous bosses. Players have the opportunity to unlock new abilities as they explore each location, along with pieces of lore and flavour text that are spread throughout the kingdom.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/Hollow_Knight_first_cover_art.webp/274px-Hollow_Knight_first_cover_art.webp.png",
                            Title = "Hollow Knight"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Description = "Ace Combat 7: Skies Unknown[a] is an arcade-style combat flight simulation video game developed and published by Bandai Namco Entertainment for the PlayStation 4 and Xbox One. The first new entry in the Ace Combat series since 2014's Ace Combat Infinity, it was released on consoles in January 2019, and for Windows via Steam following month.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Ace_Combat_7_Skies_Unknown_game_cover.jpg",
                            Title = "Ace Combat 7: Skies Unknown"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Description = "Nier: Automata is set during a proxy war between alien-created Machines and human-crafted androids, focusing on the actions of combat android 2B, scanner android 9S, and rogue prototype A2. The story requires multiple playthroughs, with each playthrough revealing new story elements. The gameplay combines role-playing elements with action-based hack-and-slash combat. It also includes gameplay from other video game genres, with elements varying from shoot 'em up to text adventure.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Nier_Automata_cover_art.jpg",
                            Title = "Nier: Automata"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Mad Max: Fury Road is a 2015 Australian post-apocalyptic dystopian action film co-written, co-produced, and directed by George Miller. Miller collaborated with Brendan McCarthy and Nico Lathouris on the screenplay. The fourth instalment in the Mad Max franchise,[7] it was produced by Village Roadshow Pictures, Kennedy Miller Mitchell, and RatPac-Dune Entertainment and distributed by Roadshow Entertainment in Australia and by Warner Bros. Pictures internationally. The film stars Tom Hardy and Charlize Theron, with Nicholas Hoult, Hugh Keays-Byrne, Rosie Huntington-Whiteley, Riley Keough, Zoë Kravitz, Abbey Lee, and Courtney Eaton in supporting roles. Set in a post-apocalyptic desert wasteland where petrol and water are scarce commodities, Fury Road follows Max Rockatansky, who joins forces with Imperator Furiosa against cult leader Immortan Joe and his army, leading to a lengthy road battle.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6e/Mad_Max_Fury_Road.jpg",
                            Title = "Mad Max: Fury Road"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "The Prestige is a 2006 psychological thriller film directed by Christopher Nolan, written by Nolan and his brother Jonathan and based on the 1995 novel by Christopher Priest. It stars Hugh Jackman as Robert Angier and Christian Bale as Alfred Borden, rival stage magicians in Victorian London who feud over a perfect teleportation trick.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Prestige_poster.jpg",
                            Title = "The Prestige"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Oldboy (Korean: 올드보이; RR: Oldeuboi; MR: Oldŭboi) is a 2003 South Korean neo-noir action thriller film directed and co-written by Park Chan-wook. A loose adaptation of the Japanese manga of the same name, the film follows the story of Oh Dae-su (Choi Min-sik), who is imprisoned in a cell that resembles a hotel room for 15 years without knowing the identity of his captor or his captor's motives. When he is finally released, Dae-su finds himself still trapped in a web of conspiracy and violence as he seeks revenge against the enigmatic Lee Woo-jin (Yoo Ji-tae). His quest becomes tied in with romance when he falls in love with a young sushi chef, Mi-do (Kang Hye-jung).",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Oldboykoreanposter.jpg",
                            Title = "Oldboy"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "The Raid 2 (Indonesian: The Raid 2: Berandal, lit. 'thug'; Japanese: ザ・レイド Gokudo, lit. 'gangster'), also known as The Raid: Retaliation, is a 2014 Indonesian action thriller film written, directed and edited by the Welsh filmmaker Gareth Evans.[6][7][8] It is the sequel to the 2011 film The Raid and stars Iko Uwais, Arifin Putra, Oka Antara, Tio Pakusadewo, Alex Abbad, Julie Estelle, Ryuhei Matsuda, Kenichi Endō, and Kazuki Kitamura. In the film, Rama is sent undercover to expose the corrupt police officials colluding with the crime families of Jakarta's criminal underworld.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Raid_2_Berandal_teaser_banner.jpeg",
                            Title = "The Raid 2"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "A Memory of Light is the 14th and final book of the fantasy series The Wheel of Time, written by American authors Robert Jordan and Brandon Sanderson, and published by Tor books. Originally expected to have been published around March 2012, the book was delayed several times, and the hardcover edition was eventually released on January 8, 2013. The book reached No. 1 on several bestsellers lists.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/27/A_Memory_of_Light_cover.jpg",
                            Title = "A Memory of Light"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "Uzumaki (うずまき, lit. \"Spiral\") is a Japanese horror manga series written and illustrated by Junji Ito. Appearing as a serial in the weekly seinen manga magazine Big Comic Spirits from 1998 to 1999, the chapters were compiled into three bound volumes by Shogakukan and published from August 1998 to September 1999. In March 2000, Shogakukan released an omnibus edition, followed by a second omnibus version in August 2010. In North America, Viz Media serialized an English-language translation of the series in its monthly magazine Pulp from February 2001 to August 2002. Viz Media then published the volumes from October 2001 to October 2002, with a re-release from October 2007 to February 2008, and published a hardcover omnibus edition in October 2013.",
                            Featured = true,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/88/Uzumaki.jpg",
                            Title = "Uzumaki"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg",
                            Title = "Dune"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Description = "The Three-Body Problem (Chinese: 三体; lit. 'Three-Body') is a science fiction novel written by the Chinese writer Liu Cixin. It is the first novel of the Remembrance of Earth's Past (Chinese: 地球往事) trilogy, but the whole series is often referred to as Three-Body. The trilogy's second and third novels are The Dark Forest and Death's End, respectively. The series portrays a fictional past, present and future where, in the first book, Earth encounters an alien civilization in a nearby star system that consists of three sun-like stars orbiting each other in an unstable system, an example of the three-body problem in orbital mechanics, giving the book its title.",
                            Featured = false,
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0f/Threebody.jpg",
                            Title = "The Three-Body Problem"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "PS5"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Stream"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Blu-ray"
                        },
                        new
                        {
                            Id = 7,
                            Name = "DVD"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Download"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Paperback"
                        },
                        new
                        {
                            Id = 10,
                            Name = "E-book"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Hardcover"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            OriginalPrice = 79.99m,
                            Price = 69.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 79.99m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 4,
                            OriginalPrice = 79.99m,
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 4,
                            OriginalPrice = 14.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 2,
                            OriginalPrice = 0m,
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 3,
                            OriginalPrice = 0m,
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 4,
                            OriginalPrice = 0m,
                            Price = 59.99m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 3.99m
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 5,
                            OriginalPrice = 0m,
                            Price = 12.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 6,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 7,
                            OriginalPrice = 0m,
                            Price = 29.99m
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 8,
                            OriginalPrice = 29.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 6,
                            OriginalPrice = 24.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 10,
                            OriginalPrice = 0m,
                            Price = 14.99m
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 12,
                            OriginalPrice = 25.99m,
                            Price = 15.99m
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 11,
                            OriginalPrice = 15.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 12,
                            ProductTypeId = 12,
                            OriginalPrice = 29.99m,
                            Price = 9.99m
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlazorShop.Shared.Address", b =>
                {
                    b.HasOne("BlazorShop.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("BlazorShop.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorShop.Shared.OrderItem", b =>
                {
                    b.HasOne("BlazorShop.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.HasOne("BlazorShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazorShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("BlazorShop.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("BlazorShop.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
