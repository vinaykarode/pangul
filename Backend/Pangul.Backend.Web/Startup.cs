﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Pangul.Backend.Web.Core;

namespace Pangul.Backend.Web
{
  public class Startup
  {
    private readonly ServiceApplication _application;

    public Startup()
    {
      _application = new ServiceApplication();
    }

    public IServiceProvider ConfigureServices(IServiceCollection services)
    {
      return _application.ConfigureServices(services);
    }

    public void Configure(IApplicationBuilder app)
    {
      _application.ConfigureApplication(app);
    }
  }
}