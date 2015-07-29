﻿using Cargo;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CargoExample
{
    public partial class Startup
    {
        private static CargoEngine _cargoEngine;
        public static CargoEngine CargoEngine { get { return _cargoEngine; } }
        
        public void ConfigureCargo(IAppBuilder app)
        {
            CargoConfiguration cargoConfig = CargoConfiguration.Default;
            _cargoEngine = new CargoEngine(cargoConfig);
            app.UseCargo(_cargoEngine);
        }
    }
}