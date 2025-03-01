﻿using Skoruba.IdentityServer4.Shared.Configuration.Configuration.Identity;
using SE.IdentityServer4.STS.Identity.Configuration.Interfaces;

namespace SE.IdentityServer4.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}







