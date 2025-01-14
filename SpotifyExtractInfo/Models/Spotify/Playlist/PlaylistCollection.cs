﻿using System.Text.Json.Serialization;

namespace SpotifyExtractInfo.Models.Spotify.Playlist
{
    public class PlaylistCollection
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("items")]
        public Playlist[] Items { get; set; }
        [JsonPropertyName("limit")]
        public int Limit { get; set; }
        [JsonPropertyName("next")]
        public string Next { get; set; }
        [JsonPropertyName("offset")]
        public int Offset { get; set; }
        [JsonPropertyName("previous")]
        public string Previous { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}
