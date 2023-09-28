using BlazorShop.Client.Shared;
using static System.Net.WebRequestMethods;

namespace BlazorShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "PS5" },
                    new ProductType { Id = 3, Name = "Xbox" },
                    new ProductType { Id = 4, Name = "PC" },
                    new ProductType { Id = 5, Name = "Stream" },
                    new ProductType { Id = 6, Name = "Blu-ray" },
                    new ProductType { Id = 7, Name = "DVD" },
                    new ProductType { Id = 8, Name = "Download" },
                    new ProductType { Id = 9, Name = "Paperback" },
                    new ProductType { Id = 10, Name = "E-book" },
                    new ProductType { Id = 11, Name = "Audiobook" },
                    new ProductType { Id = 12, Name = "Hardcover" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Games",
                    Url = "games"
                }
             );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 3,
                    Title = "Elden Ring",
                    Description = "Elden Ring[a] is a 2022 action role-playing game developed by FromSoftware. It was directed by Hidetaka Miyazaki with worldbuilding provided by fantasy writer George R. R. Martin. It was released for PlayStation 4, PlayStation 5, Windows, Xbox One, and Xbox Series X/S on February 25 by FromSoftware in Japan and Bandai Namco Entertainment internationally. Players control a customizable player character who is on a quest to repair the Elden Ring and become the new Elden Lord.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg"
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Hollow Knight",
                    Description = "Hollow Knight is a 2017 Metroidvania video game developed and published by independent developer Team Cherry. In the game, the player controls the Knight, a nameless insectoid warrior, who explores Hallownest, a fallen kingdom plagued by a supernatural disease, known as the infection. The game is set in diverse subterranean locations, featuring friendly and hostile insectoid characters and numerous bosses. Players have the opportunity to unlock new abilities as they explore each location, along with pieces of lore and flavour text that are spread throughout the kingdom.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/Hollow_Knight_first_cover_art.webp/274px-Hollow_Knight_first_cover_art.webp.png"
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 3,
                    Title = "Ace Combat 7: Skies Unknown",
                    Description = "Ace Combat 7: Skies Unknown[a] is an arcade-style combat flight simulation video game developed and published by Bandai Namco Entertainment for the PlayStation 4 and Xbox One. The first new entry in the Ace Combat series since 2014's Ace Combat Infinity, it was released on consoles in January 2019, and for Windows via Steam following month.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Ace_Combat_7_Skies_Unknown_game_cover.jpg"
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 3,
                    Title = "Nier: Automata",
                    Description = "Nier: Automata is set during a proxy war between alien-created Machines and human-crafted androids, focusing on the actions of combat android 2B, scanner android 9S, and rogue prototype A2. The story requires multiple playthroughs, with each playthrough revealing new story elements. The gameplay combines role-playing elements with action-based hack-and-slash combat. It also includes gameplay from other video game genres, with elements varying from shoot 'em up to text adventure.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/21/Nier_Automata_cover_art.jpg"
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Mad Max: Fury Road",
                    Description = "Mad Max: Fury Road is a 2015 Australian post-apocalyptic dystopian action film co-written, co-produced, and directed by George Miller. Miller collaborated with Brendan McCarthy and Nico Lathouris on the screenplay. The fourth instalment in the Mad Max franchise,[7] it was produced by Village Roadshow Pictures, Kennedy Miller Mitchell, and RatPac-Dune Entertainment and distributed by Roadshow Entertainment in Australia and by Warner Bros. Pictures internationally. The film stars Tom Hardy and Charlize Theron, with Nicholas Hoult, Hugh Keays-Byrne, Rosie Huntington-Whiteley, Riley Keough, Zoë Kravitz, Abbey Lee, and Courtney Eaton in supporting roles. Set in a post-apocalyptic desert wasteland where petrol and water are scarce commodities, Fury Road follows Max Rockatansky, who joins forces with Imperator Furiosa against cult leader Immortan Joe and his army, leading to a lengthy road battle.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6e/Mad_Max_Fury_Road.jpg"
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "The Prestige",
                    Description = "The Prestige is a 2006 psychological thriller film directed by Christopher Nolan, written by Nolan and his brother Jonathan and based on the 1995 novel by Christopher Priest. It stars Hugh Jackman as Robert Angier and Christian Bale as Alfred Borden, rival stage magicians in Victorian London who feud over a perfect teleportation trick.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d2/Prestige_poster.jpg"
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 2,
                    Title = "Oldboy",
                    Description = "Oldboy (Korean: 올드보이; RR: Oldeuboi; MR: Oldŭboi) is a 2003 South Korean neo-noir action thriller film directed and co-written by Park Chan-wook. A loose adaptation of the Japanese manga of the same name, the film follows the story of Oh Dae-su (Choi Min-sik), who is imprisoned in a cell that resembles a hotel room for 15 years without knowing the identity of his captor or his captor's motives. When he is finally released, Dae-su finds himself still trapped in a web of conspiracy and violence as he seeks revenge against the enigmatic Lee Woo-jin (Yoo Ji-tae). His quest becomes tied in with romance when he falls in love with a young sushi chef, Mi-do (Kang Hye-jung).",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/67/Oldboykoreanposter.jpg"
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 2,
                    Title = "The Raid 2",
                    Description = "The Raid 2 (Indonesian: The Raid 2: Berandal, lit. 'thug'; Japanese: ザ・レイド Gokudo, lit. 'gangster'), also known as The Raid: Retaliation, is a 2014 Indonesian action thriller film written, directed and edited by the Welsh filmmaker Gareth Evans.[6][7][8] It is the sequel to the 2011 film The Raid and stars Iko Uwais, Arifin Putra, Oka Antara, Tio Pakusadewo, Alex Abbad, Julie Estelle, Ryuhei Matsuda, Kenichi Endō, and Kazuki Kitamura. In the film, Rama is sent undercover to expose the corrupt police officials colluding with the crime families of Jakarta's criminal underworld.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c3/The_Raid_2_Berandal_teaser_banner.jpeg"
                },
                new Product
                {
                    Id = 9,
                    CategoryId = 1,
                    Title = "A Memory of Light",
                    Description = "A Memory of Light is the 14th and final book of the fantasy series The Wheel of Time, written by American authors Robert Jordan and Brandon Sanderson, and published by Tor books. Originally expected to have been published around March 2012, the book was delayed several times, and the hardcover edition was eventually released on January 8, 2013. The book reached No. 1 on several bestsellers lists.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/27/A_Memory_of_Light_cover.jpg"
                },
                new Product
                {
                    Id = 10,
                    CategoryId = 1,
                    Title = "Necronomicon: The Weird Tales of H.P. Lovecraft",
                    Description = "This handsome leatherbound tome collects together the very best of Lovecraft's tales of terror, including the complete Cthulhu Mythos cycle, just the way they were originally published. It will introduce a whole new generation of readers to Lovecraft's fiction, as well as being a must-buy for those fans who want all his work in a single, definitive, highly attractive volume.",
                    ImageUrl = "https://m.media-amazon.com/images/I/61ccDaC9jTL._SL1418_.jpg"
                },
                new Product
                {
                    Id = 11,
                    CategoryId = 1,
                    Title = "Dune",
                    Description = "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune Chronicles. It is one of the world's best-selling science fiction novels.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/de/Dune-Frank_Herbert_%281965%29_First_edition.jpg"
                },
                new Product
                {
                    Id = 12,
                    CategoryId = 1,
                    Title = "The Three-Body Problem",
                    Description = "The Three-Body Problem (Chinese: 三体; lit. 'Three-Body') is a science fiction novel written by the Chinese writer Liu Cixin. It is the first novel of the Remembrance of Earth's Past (Chinese: 地球往事) trilogy, but the whole series is often referred to as Three-Body. The trilogy's second and third novels are The Dark Forest and Death's End, respectively. The series portrays a fictional past, present and future where, in the first book, Earth encounters an alien civilization in a nearby star system that consists of three sun-like stars orbiting each other in an unstable system, an example of the three-body problem in orbital mechanics, giving the book its title.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0f/Threebody.jpg"
                }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 7.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 4,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 4,
                    Price = 7.99m,
                    OriginalPrice = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 6.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 3.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    Price = 9.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 4,
                    Price = 19.99m
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 5,
                    Price = 3.99m,
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 5,
                    Price = 2.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 6,
                    Price = 19.99m,
                    OriginalPrice = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 7,
                    Price = 69.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 8,
                    Price = 49.99m,
                    OriginalPrice = 59.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 9,
                    Price = 9.99m,
                    OriginalPrice = 24.99m,
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 10,
                    Price = 14.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 11,
                    Price = 15.99m,
                    OriginalPrice = 29m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 12,
                    Price = 9.99m,
                    OriginalPrice = 39m
                },
                new ProductVariant
                {
                    ProductId = 12,
                    ProductTypeId = 12,
                    Price = 9.99m,
                    OriginalPrice = 39m
                }
            );
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<ProductType> ProductTypes { get; set;}
        public DbSet<ProductVariant> ProductVariants { get; set;}
    }
}
