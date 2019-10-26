using System;
using System.Collections.Generic;
using System.Text;

namespace SeasonTracker.Models
{
    public class Watchlist
    {
        public int Id { get; set; }

        public string TvShowName { get; set; }

        public string Season { get; set; }

        public string NumberOfEpisodes { get; set; }

        public string EpisodeViewlist { get; set; }
    }
}
