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

        public JPlayer GetPlayerById(string id)
        {
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player + id);

            HttpStatusCode status;
            var raw_match = Request.DoRequest(uri, out status, az.GetAPIKey());


            return JPlayer.FromJson(raw_match);
        }

        public JPlayers GetPlayersByIds(List<string> ids)
        {
            var sid = string.Join(",", ids);
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player_ids + sid);

            HttpStatusCode status;
            var raw_match = Request.DoRequest(uri, out status, az.GetAPIKey());


            return JPlayers.FromJson(raw_match);
        }


        public JPlayers GetPlayersByNames(List<string> names)
        {
            var sid = string.Join(",", names);
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.player_names + sid);

            HttpStatusCode status;
            var raw_match = Request.DoRequest(uri, out status, az.GetAPIKey());


            return JPlayers.FromJson(raw_match);
        }
    }
}