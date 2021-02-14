using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Game: IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
    }
}
