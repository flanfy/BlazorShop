using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorShop.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "Books", "books" },
                    { 2, "Movies", "movies" },
                    { 3, "Games", "games" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 3, "Elden Ring[a] is a 2022 action role-playing game developed by FromSoftware. It was directed by Hidetaka Miyazaki with worldbuilding provided by fantasy writer George R. R. Martin. It was released for PlayStation 4, PlayStation 5, Windows, Xbox One, and Xbox Series X/S on February 25 by FromSoftware in Japan and Bandai Namco Entertainment internationally. Players control a customizable player character who is on a quest to repair the Elden Ring and become the new Elden Lord.", "https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg", 79.99m, "Elden Ring" },
                    { 2, 3, "Hollow Knight is a 2017 Metroidvania video game developed and published by independent developer Team Cherry. In the game, the player controls the Knight, a nameless insectoid warrior, who explores Hallownest, a fallen kingdom plagued by a supernatural disease, known as the infection. The game is set in diverse subterranean locations, featuring friendly and hostile insectoid characters and numerous bosses. Players have the opportunity to unlock new abilities as they explore each location, along with pieces of lore and flavour text that are spread throughout the kingdom.", "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/Hollow_Knight_first_cover_art.webp/274px-Hollow_Knight_first_cover_art.webp.png", 19.99m, "Hollow Knight" },
                    { 3, 3, "Ace Combat 7: Skies Unknown[a] is an arcade-style combat flight simulation video game developed and published by Bandai Namco Entertainment for the PlayStation 4 and Xbox One. The first new entry in the Ace Combat series since 2014's Ace Combat Infinity, it was released on consoles in January 2019, and for Windows via Steam following month.", "https://upload.wikimedia.org/wikipedia/en/2/22/Ace_Combat_7_Skies_Unknown_game_cover.jpg", 59.99m, "Ace Combat 7: Skies Unknown" },
                    { 4, 3, "Nier: Automata is set during a proxy war between alien-created Machines and human-crafted androids, focusing on the actions of combat android 2B, scanner android 9S, and rogue prototype A2. The story requires multiple playthroughs, with each playthrough revealing new story elements. The gameplay combines role-playing elements with action-based hack-and-slash combat. It also includes gameplay from other video game genres, with elements varying from shoot 'em up to text adventure.", "https://upload.wikimedia.org/wikipedia/en/2/21/Nier_Automata_cover_art.jpg", 59.99m, "Nier: Automata" },
                    { 5, 2, "Mad Max: Fury Road is a 2015 Australian post-apocalyptic dystopian action film co-written, co-produced, and directed by George Miller. Miller collaborated with Brendan McCarthy and Nico Lathouris on the screenplay. The fourth instalment in the Mad Max franchise,[7] it was produced by Village Roadshow Pictures, Kennedy Miller Mitchell, and RatPac-Dune Entertainment and distributed by Roadshow Entertainment in Australia and by Warner Bros. Pictures internationally. The film stars Tom Hardy and Charlize Theron, with Nicholas Hoult, Hugh Keays-Byrne, Rosie Huntington-Whiteley, Riley Keough, Zoë Kravitz, Abbey Lee, and Courtney Eaton in supporting roles. Set in a post-apocalyptic desert wasteland where petrol and water are scarce commodities, Fury Road follows Max Rockatansky, who joins forces with Imperator Furiosa against cult leader Immortan Joe and his army, leading to a lengthy road battle.", "https://upload.wikimedia.org/wikipedia/en/6/6e/Mad_Max_Fury_Road.jpg", 9.99m, "Mad Max: Fury Road" },
                    { 6, 2, "The Prestige is a 2006 psychological thriller film directed by Christopher Nolan, written by Nolan and his brother Jonathan and based on the 1995 novel by Christopher Priest. It stars Hugh Jackman as Robert Angier and Christian Bale as Alfred Borden, rival stage magicians in Victorian London who feud over a perfect teleportation trick.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Prestige_poster.jpg", 9.99m, "The Prestige" },
                    { 7, 2, "Oldboy (Korean: 올드보이; RR: Oldeuboi; MR: Oldŭboi) is a 2003 South Korean neo-noir action thriller film directed and co-written by Park Chan-wook. A loose adaptation of the Japanese manga of the same name, the film follows the story of Oh Dae-su (Choi Min-sik), who is imprisoned in a cell that resembles a hotel room for 15 years without knowing the identity of his captor or his captor's motives. When he is finally released, Dae-su finds himself still trapped in a web of conspiracy and violence as he seeks revenge against the enigmatic Lee Woo-jin (Yoo Ji-tae). His quest becomes tied in with romance when he falls in love with a young sushi chef, Mi-do (Kang Hye-jung).", "https://upload.wikimedia.org/wikipedia/en/6/67/Oldboykoreanposter.jpg", 9.99m, "Oldboy" },
                    { 8, 2, "The Raid 2 (Indonesian: The Raid 2: Berandal, lit. 'thug'; Japanese: ザ・レイド Gokudo, lit. 'gangster'), also known as The Raid: Retaliation, is a 2014 Indonesian action thriller film written, directed and edited by the Welsh filmmaker Gareth Evans.[6][7][8] It is the sequel to the 2011 film The Raid and stars Iko Uwais, Arifin Putra, Oka Antara, Tio Pakusadewo, Alex Abbad, Julie Estelle, Ryuhei Matsuda, Kenichi Endō, and Kazuki Kitamura. In the film, Rama is sent undercover to expose the corrupt police officials colluding with the crime families of Jakarta's criminal underworld.", "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Raid_2_Berandal_teaser_banner.jpeg", 9.99m, "The Raid 2" },
                    { 9, 1, "A Memory of Light is the 14th and final book of the fantasy series The Wheel of Time, written by American authors Robert Jordan and Brandon Sanderson, and published by Tor books. Originally expected to have been published around March 2012, the book was delayed several times, and the hardcover edition was eventually released on January 8, 2013. The book reached No. 1 on several bestsellers lists.", "https://upload.wikimedia.org/wikipedia/en/2/27/A_Memory_of_Light_cover.jpg", 9.99m, "A Memory of Light" },
                    { 10, 1, "This handsome leatherbound tome collects together the very best of Lovecraft's tales of terror, including the complete Cthulhu Mythos cycle, just the way they were originally published. It will introduce a whole new generation of readers to Lovecraft's fiction, as well as being a must-buy for those fans who want all his work in a single, definitive, highly attractive volume.", "https://m.media-amazon.com/images/I/61ccDaC9jTL._SL1418_.jpg", 9.99m, "Necronomicon: The Weird Tales of H.P. Lovecraft" },
                    { 11, 1, "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.", "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg", 9.99m, "Dune" },
                    { 12, 1, "The Three-Body Problem (Chinese: 三体; lit. 'Three-Body') is a science fiction novel written by the Chinese writer Liu Cixin. It is the first novel of the Remembrance of Earth's Past (Chinese: 地球往事) trilogy, but the whole series is often referred to as Three-Body. The trilogy's second and third novels are The Dark Forest and Death's End, respectively. The series portrays a fictional past, present and future where, in the first book, Earth encounters an alien civilization in a nearby star system that consists of three sun-like stars orbiting each other in an unstable system, an example of the three-body problem in orbital mechanics, giving the book its title.", "https://upload.wikimedia.org/wikipedia/en/0/0f/Threebody.jpg", 9.99m, "The Three-Body Problem" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
