﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorShop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Elden Ring",
                Description = "Elden Ring[a] is a 2022 action role-playing game developed by FromSoftware. It was directed by Hidetaka Miyazaki with worldbuilding provided by fantasy writer George R. R. Martin. It was released for PlayStation 4, PlayStation 5, Windows, Xbox One, and Xbox Series X/S on February 25 by FromSoftware in Japan and Bandai Namco Entertainment internationally. Players control a customizable player character who is on a quest to repair the Elden Ring and become the new Elden Lord.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/b9/Elden_Ring_Box_art.jpg",
                Price = 79.99m
            },
            new Product
            {
                Id = 2,
                Title = "Hollow Knight",
                Description = "Hollow Knight is a 2017 Metroidvania video game developed and published by independent developer Team Cherry. In the game, the player controls the Knight, a nameless insectoid warrior, who explores Hallownest, a fallen kingdom plagued by a supernatural disease, known as the infection. The game is set in diverse subterranean locations, featuring friendly and hostile insectoid characters and numerous bosses. Players have the opportunity to unlock new abilities as they explore each location, along with pieces of lore and flavour text that are spread throughout the kingdom.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/Hollow_Knight_first_cover_art.webp/274px-Hollow_Knight_first_cover_art.webp.png",
                Price = 19.99m
            },
            new Product
            {
                Id = 3,
                Title = "Ace Combat 7: Skies Unknown",
                Description = "Ace Combat 7: Skies Unknown[a] is an arcade-style combat flight simulation video game developed and published by Bandai Namco Entertainment for the PlayStation 4 and Xbox One. The first new entry in the Ace Combat series since 2014's Ace Combat Infinity, it was released on consoles in January 2019, and for Windows via Steam following month.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/22/Ace_Combat_7_Skies_Unknown_game_cover.jpg",
                Price = 9.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
