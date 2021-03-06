﻿using baseVISION.Tool.Connectors.Harvest.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace baseVISION.Tool.Connectors.Harvest.Model
{
    public class ResultClients : IHarvestResult
    {
        [JsonProperty("clients")]
        public List<Client> Clients { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; set; }

        [JsonProperty("total_entries")]
        public long TotalEntries { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

    }
}
