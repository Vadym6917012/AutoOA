﻿using AutoOA.Core;
using AutoOA.Repository.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoOA.Repository
{
    public class VehicleRepository
    {
        private readonly AutoOADbContext _ctx;
        
        public VehicleRepository(AutoOADbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Vehicle> AllVehicle => _ctx.Vehicles;

    }
}
