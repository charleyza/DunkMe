﻿using System;

namespace Repository.Schema
{
    public class GameTypeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
    }
}
