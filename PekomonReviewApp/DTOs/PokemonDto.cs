﻿namespace PokemonReviewApp.DTOs
{
    public class PokemonDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
    }
}