using System;
using System.Collections.Generic;
using System.Net;
using PUBGSDK.JClass.Players.Collection;
using PUBGSDK.JClass.Players.Single;
using PUBGSDK.Tools;

namespace PUBGSDK
{
    public class Player
    {
        private readonly Authorization az;

        public Player(Authorization authorization)
        {
            az = authorization;
        }

        public Tuple<JPlayer, Request.ResponseInfo> GetPlayerById(string id)
        {
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player + id);

            HttpStatusCode status;
            int requestsRemaining;
            var raw_match = Request.DoRequest(uri, az.GetAPIKey());

            return new Tuple<JPlayer, Request.ResponseInfo>(JPlayer.FromJson(raw_match.response), raw_match);
        }

        public Tuple<JPlayers, Request.ResponseInfo> GetPlayersByIds(List<string> ids)
        {
            var sid = string.Join(",", ids);
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player_ids + sid);

            HttpStatusCode status;
            int requestsRemaining;
            var raw_match = Request.DoRequest(uri, az.GetAPIKey());


            return new Tuple<JPlayers, Request.ResponseInfo>(JPlayers.FromJson(raw_match.response), raw_match);
        }


        public Tuple<JPlayers, Request.ResponseInfo> GetPlayersByNames(List<string> names)
        {
            var sid = string.Join(",", names);
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player_names + sid);

            HttpStatusCode status;
            int requestsRemaining;
            var raw_match = Request.DoRequest(uri, az.GetAPIKey());


            return new Tuple<JPlayers, Request.ResponseInfo>(JPlayers.FromJson(raw_match.response), raw_match);
        }
    }
}