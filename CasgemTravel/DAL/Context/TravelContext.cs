﻿using CasgemTravel.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace CasgemTravel.DAL.Context
{
    public class TravelContext : DbContext
    {
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Travel> Travels { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}