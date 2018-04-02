using System;

namespace PUBGSDK
{
    public class Authorization
    {
        public enum Region
        {
            xbox_as,
            xbox_eu,
            xbox_na,
            xbox_oc,
            pc_krjp,
            pc_na,
            pc_eu,
            pc_oc,
            pc_kakao,
            pc_sea,
            pc_sa,
            pc_as
        }

        private string ApiKey;
        private Region region;

        public Authorization(string apiKey, Region region = Region.pc_eu)
        {
            this.region = region;
            ApiKey = apiKey;
        }

        public void SetRegion(Region r)
        {
            region = r;
        }

        public Region GetRegion()
        {
            return region;
        }


        public void SetAPIKey(string api_key)
        {
            ApiKey = api_key;
        }

        public string GetAPIKey()
        {
            return ApiKey;
        }


        public string GetRegionF()
        {
            switch (GetRegion())
            {
                case Region.xbox_as:
                    return "xbox-as";
                case Region.xbox_eu:
                    return "xbox-eu";
                case Region.xbox_na:
                    return "xbox-na";
                case Region.xbox_oc:
                    return "xbox-oc";
                case Region.pc_krjp:
                    return "pc_krjp";
                case Region.pc_na:
                    return "pc-na";
                case Region.pc_eu:
                    return "pc-eu";
                case Region.pc_oc:
                    return "pc-oc";
                case Region.pc_kakao:
                    return "pc-kakao";
                case Region.pc_sea:
                    return "pc-sea";
                case Region.pc_sa:
                    return "pc-sa";
                case Region.pc_as:
                    return "pc-as";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}