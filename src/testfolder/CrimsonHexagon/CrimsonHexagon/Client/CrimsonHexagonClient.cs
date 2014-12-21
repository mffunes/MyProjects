using System;
using System.Collections.Generic;
using CrimsonHexagon.Config;
using CrimsonHexagon.Model;
using CrimsonHexagon.Model.Authorization;
using Sources.Infrastructure;

namespace CrimsonHexagon.Client
{
    public class CrimsonHexagonClient<T, Z> : BaseClient, ICrimsonHexagonClient
        where T : ICrimsonHexagonSourceConfig
        where Z : ICrimsonHexagonResponse
    {
        private AuthorizationResponse AuthorizationResponse { get; set; }
        private T Config { get; set; }

        public CrimsonHexagonClient(T config)
        {
            this.Config = config;
        }

        public IList<CrimsonHexagonItem> GetCrimsonHexagonItems()
        {
            CrimsonHexagonConfiguration configuration = new CrimsonHexagonConfiguration(this.Config.Method);
            CrimsonHexagonBaseRequest request = this.Config.GetRequestObject();
            request.AuthorizationToken = this.GetAuthorizationToken();
            Z response = this.GetObjectFromUrl<Z>(configuration, request);

            return response.GetCrimsonHexagonItem();
        }

        private string GetAuthorizationToken()
        {
            if (this.AuthorizationResponse == null || this.AuthorizationResponse.expires < DateTime.Now)
            {
                CrimsonHexagonConfiguration configuration = new CrimsonHexagonConfiguration("authenticate");
                AuthorizationRequest request = new AuthorizationRequest { UserName = "user", Password = "password" };
                this.AuthorizationResponse = this.GetObjectFromUrl<AuthorizationResponse>(configuration, request);
            }

            return this.AuthorizationResponse.auth;
        }


    }
}
