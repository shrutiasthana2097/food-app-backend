﻿namespace Intro.API.Model
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Direction { get; set; }
        public DateTime Created { get; set; }
    }
}
