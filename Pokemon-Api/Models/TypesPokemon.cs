﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon_Api.Models
{
    public class TypesPokemon
    {
        public int Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
