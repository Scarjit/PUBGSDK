﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using PUBGSDK.JClass.Matches;
using PUBGSDK.Tools;

namespace PUBGSDK
{
    public class Match
    {
        private readonly Authorization az;

        public Match(Authorization authorization)
        {
            az = authorization;
        }

        public Tuple<JMatch, Request.ResponseInfo> GetMatchById(string id)
        {
            var uri = new Uri(URL.base_url + URL.base_extension + az.GetRegionF() + "/" + URL.match + id);
            var raw_match = Request.DoRequest(uri, az.GetAPIKey());

            return new Tuple<JMatch, Request.ResponseInfo>(JMatch.FromJson(raw_match.response), raw_match);
        }

        public List<IncludedAttributes> GetTelemetry(JMatch m)
        {
            var data = m.Data.Relationships.Assets.Data;
            var included = m.Included;

            return (from datum in data
                    where datum.Type == DatumType.Asset
                    select datum.Id
                    into id
                    select included.Where(x => x.Id == id).First(x => x.Attributes.Name == "telemetry").Attributes)
                .ToList();
        }
    }
}