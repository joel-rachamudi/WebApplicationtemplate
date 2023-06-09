﻿using Newtonsoft.Json;
namespace WebApplicationtemplate.Models

{
    class Product
    {
       
            [JsonProperty("Alternate names")]
            public string Alternatenames { get; set; }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Launched { get; set; }

            [JsonProperty("Console Family")]
            public string ConsoleFamily { get; set; }

            [JsonProperty("Console Type")]
            public string ConsoleType { get; set; }

            [JsonProperty("Input method")]
            public string Inputmethod { get; set; }

            [JsonProperty("Hard Disk")]
            public string HardDisk { get; set; }
            public string RAM { get; set; }
            public string Processor { get; set; }
            public string Graphics { get; set; }
            public string Ethernet { get; set; }
            public string Weight { get; set; }
            public string HDMI { get; set; }
            public string USB { get; set; }

            [JsonProperty("AV Digital Output")]
            public string AVDigitalOutput { get; set; }

            [JsonProperty("Wi-Fi")]
            public string WiFi { get; set; }

            [JsonProperty("5 Stars")]
            public string _5Stars { get; set; }

            [JsonProperty("4 Stars")]
            public string _4Stars { get; set; }

            [JsonProperty("3 Stars")]
            public string _3Stars { get; set; }

            [JsonProperty("2 Stars")]
            public string _2Stars { get; set; }

            [JsonProperty("1 Stars")]
            public string _1Stars { get; set; }

            [JsonProperty("Total Ratings")]
            public string TotalRatings { get; set; }

            [JsonProperty("Picture URL")]
            public string PictureURL { get; set; }
            public string url { get; set; }

            [JsonProperty("Product Name")]
            public string ProductName { get; set; }

            [JsonProperty("Price in India")]
            public string PriceinIndia { get; set; }
        
    }



}