using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EchoNest.Net.Core.Common;
using EchoNest.Net.Core.Entities;
using EchoNest.Net.Core.Interfaces;
using EchoNest.Net.Core.Options;
using Newtonsoft.Json;

namespace EchoNest.Net.Core.Managers
{
    public class SongManager
    {
        private readonly IWebManager _webManager;
        public SongManager(IWebManager webManager)
        {
            _webManager = webManager;
        }

        public SongManager(string authenticationToken)
            : this(new WebManager(authenticationToken))
        {
        }

        public async Task<EchoNestHttpResponse> SearchSongsAsync(string[] bucketParameters, SongSearch searchOptions,
            int results = 15, int start = 0)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var uriBase = string.Format(EndPoints.SongSearch, _webManager.ApiKey, results, start) + bucket;
            uriBase += "&limit=" + searchOptions.Limit.ToString().ToLower();

            var description = searchOptions.Description?.Aggregate(string.Empty, (current, parameter) => current + ("&description=" + parameter));

            if (!string.IsNullOrEmpty(description))
            {
                uriBase += description;
            }

            var songType = searchOptions.SongType?.Aggregate(string.Empty, (current, parameter) => current + ("&song_type=" + parameter));

            if (!string.IsNullOrEmpty(songType))
            {
                uriBase += songType;
            }

            var mood = searchOptions.Mood?.Aggregate(string.Empty, (current, parameter) => current + ("&mood=" + parameter));

            if (!string.IsNullOrEmpty(mood))
            {
                uriBase += mood;
            }

            var style = searchOptions.Style?.Aggregate(string.Empty, (current, parameter) => current + ("&style=" + parameter));

            if (!string.IsNullOrEmpty(style))
            {
                uriBase += style;
            }

            if (!string.IsNullOrEmpty(searchOptions.RankType))
            {
                uriBase += "&rank_type=" + searchOptions.RankType;
            }

            if (!string.IsNullOrEmpty(searchOptions.ArtistId))
            {
                uriBase += "&artist_id=" + searchOptions.RankType;
            }

            if (searchOptions.MaxTempo >= 0)
            {
                uriBase += "&max_tempo=" + searchOptions.MaxTempo;
            }

            if (searchOptions.MinTempo >= 0)
            {
                uriBase += "&min_tempo=" + searchOptions.MinTempo;
            }

            if (searchOptions.MaxAcousticness >= 0)
            {
                uriBase += "&max_acousticness=" + searchOptions.MaxAcousticness;
            }

            if (searchOptions.MinAcousticness >= 0)
            {
                uriBase += "&min_acousticness=" + searchOptions.MinAcousticness;
            }

            if (searchOptions.MaxSpeechiness >= 0)
            {
                uriBase += "&max_speechiness=" + searchOptions.MaxSpeechiness;
            }

            if (searchOptions.MinSpeechiness >= 0)
            {
                uriBase += "&min_speechiness=" + searchOptions.MinSpeechiness;
            }

            if (searchOptions.MaxLiveness >= 0)
            {
                uriBase += "&max_liveness=" + searchOptions.MaxLiveness;
            }

            if (searchOptions.MinLiveness >= 0)
            {
                uriBase += "&min_liveness=" + searchOptions.MinLiveness;
            }

            if (searchOptions.MaxDanceability >= 0)
            {
                uriBase += "&max_danceability=" + searchOptions.MaxDanceability;
            }

            if (searchOptions.MinDanceability >= 0)
            {
                uriBase += "&min_danceability=" + searchOptions.MinDanceability;
            }

            if (searchOptions.MaxLatitude >= -90 && searchOptions.MaxLatitude <= 90)
            {
                uriBase += "&max_longitude=" + searchOptions.MaxLatitude;
            }

            if (searchOptions.MinLatitude >= -90 && searchOptions.MinLatitude <= 90)
            {
                uriBase += "&min_longitude=" + searchOptions.MinLatitude;
            }


            if (searchOptions.MaxLongitude >= -180 && searchOptions.MaxLongitude <= 180)
            {
                uriBase += "&max_longitude=" + searchOptions.MaxLongitude;
            }

            if (searchOptions.MinLongitude >= -180 && searchOptions.MinLongitude <= 180)
            {
                uriBase += "&min_longitude=" + searchOptions.MinLongitude;
            }

            if (searchOptions.ArtistMaxHotttnesss >= 0)
            {
                uriBase += "&artist_max_hotttnesss=" + searchOptions.ArtistMaxHotttnesss;
            }

            if (searchOptions.ArtistMinHotttnesss >= 0)
            {
                uriBase += "&artist_min_hotttnesss=" + searchOptions.ArtistMinHotttnesss;
            }

            if (searchOptions.SongMaxHotttnesss >= 0)
            {
                uriBase += "&song_max_hotttnesss=" + searchOptions.SongMaxHotttnesss;
            }

            if (searchOptions.SongMinHotttnesss >= 0)
            {
                uriBase += "&song_min_hotttnesss=" + searchOptions.SongMinHotttnesss;
            }

            if (searchOptions.ArtistMaxFamiliarity >= 0)
            {
                uriBase += "&artist_max_familiarity=" + searchOptions.ArtistMaxFamiliarity;
            }

            if (searchOptions.ArtistMinFamiliarity >= 0)
            {
                uriBase += "&artist_max_familiarity=" + searchOptions.ArtistMinFamiliarity;
            }

            if (searchOptions.MaxLoudness >= 0)
            {
                uriBase += "&max_loudness=" + searchOptions.MaxLoudness;
            }

            if (searchOptions.MinLoudness >= 0)
            {
                uriBase += "&min_loudness=" + searchOptions.MinLoudness;
            }

            if (searchOptions.MaxDuration >= 0)
            {
                uriBase += "&max_duration=" + searchOptions.MaxDuration;
            }

            if (searchOptions.MinDuration >= 0)
            {
                uriBase += "&min_duration=" + searchOptions.MinDuration;
            }

            if (searchOptions.IsArtistStillActiveSearch)
            {
                uriBase += "&artist_end_year_after=present";
            }
            else if (searchOptions.ArtistEndYearAfter >= 0)
            {
                uriBase += "&artist_end_year_after=" + searchOptions.ArtistEndYearAfter;
            }

            if (searchOptions.IsArtistNotActiveSearch)
            {
                uriBase += "&artist_end_year_before=present";
            }
            else if (searchOptions.ArtistEndYearBefore >= 0)
            {
                uriBase += "&artist_end_year_before=" + searchOptions.ArtistEndYearBefore;
            }

            if (searchOptions.ArtistStartYearAfter >= 0)
            {
                uriBase += "&artist_start_year_after=" + searchOptions.ArtistStartYearAfter;
            }

            if (searchOptions.ArtistStartYearBefore >= 0)
            {
                uriBase += "&artist_start_year_before=" + searchOptions.ArtistStartYearBefore;
            }

            if (!string.IsNullOrEmpty(searchOptions.Sort))
            {
                uriBase += "&sort=" + searchOptions.Sort;
            }

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }

        public async Task<EchoNestHttpResponse> GetSongProfilesAsync(string[] bucketParameters, string[] ids,
            string[] trackids, bool limit)
        {
            var bucket = bucketParameters?.Aggregate(string.Empty, (current, parameter) => current + ("&bucket=" + parameter));
            if (bucket == null)
            {
                throw new Exception("Need to add bucket parameters");
            }

            var idString = ids?.Aggregate(string.Empty, (current, parameter) => current + ("&id=" + parameter));
            var trackIdString = trackids?.Aggregate(string.Empty, (current, parameter) => current + ("&track_id=" + parameter));
            var uriBase = string.Format(EndPoints.SongProfile, _webManager.ApiKey, idString, trackIdString) + bucket;
            uriBase += "&limit=" + limit.ToString().ToLower();

            var result = await _webManager.GetData(new Uri(uriBase));
            var response = JsonConvert.DeserializeObject<Response>(result.ResultJson);
            return response.EchoNestHttpResponse;
        }
    }
}
