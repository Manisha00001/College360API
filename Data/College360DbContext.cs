using College360API.Models;
using Microsoft.EntityFrameworkCore;

namespace College360API.Data
{
    public class College360DbContext : DbContext
    {
        public College360DbContext(
            DbContextOptions<College360DbContext> options)
            : base(options)
        {
        }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Navigation> Navigations { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // =========================================
            // LOCATIONS
            // =========================================

            modelBuilder.Entity<Location>().HasData(

                new Location
                {
                    Id = 1,
                    Name = "Main Entrance",
                    ImagePath = "assets/img1.jpg",
                    Description = "College main entrance",
                    Floor = 1,
                    X = 100,
                    Y = 100
                },

                new Location
                {
                    Id = 2,
                    Name = "Reception",
                    ImagePath = "assets/img2.jpg",
                    Description = "College reception area",
                    Floor = 1,
                    X = 200,
                    Y = 100
                },

                new Location
                {
                    Id = 3,
                    Name = "Corridor",
                    ImagePath = "assets/img3.jpg",
                    Description = "Main corridor",
                    Floor = 1,
                    X = 300,
                    Y = 100
                },

                new Location
                {
                    Id = 4,
                    Name = "Department Office",
                    ImagePath = "assets/img4.jpg",
                    Description = "Department office area",
                    Floor = 1,
                    X = 300,
                    Y = 200
                },

                new Location
                {
                    Id = 5,
                    Name = "Staircase",
                    ImagePath = "assets/img5.jpg",
                    Description = "Staircase area",
                    Floor = 1,
                    X = 200,
                    Y = 200
                },

                new Location
                {
                    Id = 6,
                    Name = "Location 6",
                    ImagePath = "assets/img6.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 200
                },

                new Location
                {
                    Id = 7,
                    Name = "Location 7",
                    ImagePath = "assets/img7.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 300
                },

                new Location
                {
                    Id = 8,
                    Name = "Location 8",
                    ImagePath = "assets/img8.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 400
                },

                new Location
                {
                    Id = 9,
                    Name = "Location 9",
                    ImagePath = "assets/img9.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 500
                },

                new Location
                {
                    Id = 10,
                    Name = "Location 10",
                    ImagePath = "assets/img10.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 600
                },

                new Location
                {
                    Id = 11,
                    Name = "Location 11",
                    ImagePath = "assets/img11.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 700
                },

                new Location
                {
                    Id = 12,
                    Name = "Location 12",
                    ImagePath = "assets/img12.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 800
                },

                new Location
                {
                    Id = 13,
                    Name = "Location 13",
                    ImagePath = "assets/img13.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 900
                },

                new Location
                {
                    Id = 14,
                    Name = "Location 14",
                    ImagePath = "assets/img14.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 1000
                },

                new Location
                {
                    Id = 15,
                    Name = "Location 15",
                    ImagePath = "assets/img15.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 1100
                },

                new Location
                {
                    Id = 16,
                    Name = "Location 16",
                    ImagePath = "assets/img16.jpg",
                    Description = "",
                    Floor = 1,
                    X = 100,
                    Y = 1200
                }
            );


            // =========================================
            // NAVIGATIONS
            // =========================================

            modelBuilder.Entity<Navigation>().HasData(

                // -----------------------------------------
                // Main Entrance → Reception
                // -----------------------------------------

                new Navigation
                {
                    Id = 1,
                    FromLocationId = 1,
                    ToLocationId = 2,
                    Pitch = 0,
                    Yaw = 0,
                    EntryYaw = 0,
                    Direction = "Forward"
                },

                // Reception → Main Entrance
                new Navigation
                {
                    Id = 2,
                    FromLocationId = 2,
                    ToLocationId = 1,
                    Pitch = 0,
                    Yaw = 180, 
                    EntryYaw = 0,       // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Reception → Corridor
                // -----------------------------------------

                new Navigation
                {
                    Id = 3,
                    FromLocationId = 2,
                    ToLocationId = 3,
                    Pitch = 0,
                    Yaw = 0, 
                    EntryYaw = 60,         // EDIT THIS
                    Direction = "Forward"
                },

                // Corridor → Reception
                new Navigation
                {
                    Id = 4,
                    FromLocationId = 3,
                    ToLocationId = 2,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Corridor → Department Office
                // -----------------------------------------

                new Navigation
                {
                    Id = 5,
                    FromLocationId = 3,
                    ToLocationId = 4,
                    Pitch = 0,
                    Yaw = 60,          // EDIT THIS
                    Direction = "Forward"
                },

                // Department Office → Corridor
                new Navigation
                {
                    Id = 6,
                    FromLocationId = 4,
                    ToLocationId = 3,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Department Office → Staircase
                // -----------------------------------------

                new Navigation
                {
                    Id = 7,
                    FromLocationId = 4,
                    ToLocationId = 5,
                    Pitch = 0,
                    Yaw = 0,   
                    EntryYaw = 30,       // EDIT THIS
                    Direction = "Forward"
                },

                // Staircase → Department Office
                new Navigation
                {
                    Id = 8,
                    FromLocationId = 5,
                    ToLocationId = 4,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 5 → Location 6
                // -----------------------------------------

                new Navigation
                {
                    Id = 9,
                    FromLocationId = 5,
                    ToLocationId = 6,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 10,
                    FromLocationId = 6,
                    ToLocationId = 5,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 6 → Location 7
                // -----------------------------------------

                new Navigation
                {
                    Id = 11,
                    FromLocationId = 6,
                    ToLocationId = 7,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 12,
                    FromLocationId = 7,
                    ToLocationId = 6,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 7 → Location 8
                // -----------------------------------------

                new Navigation
                {
                    Id = 13,
                    FromLocationId = 7,
                    ToLocationId = 8,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 14,
                    FromLocationId = 8,
                    ToLocationId = 7,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 8 → Location 9
                // -----------------------------------------

                new Navigation
                {
                    Id = 15,
                    FromLocationId = 8,
                    ToLocationId = 9,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 16,
                    FromLocationId = 9,
                    ToLocationId = 8,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 9 → Location 10
                // -----------------------------------------

                new Navigation
                {
                    Id = 17,
                    FromLocationId = 9,
                    ToLocationId = 10,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 18,
                    FromLocationId = 10,
                    ToLocationId = 9,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 10 → Location 11
                // -----------------------------------------

                new Navigation
                {
                    Id = 19,
                    FromLocationId = 10,
                    ToLocationId = 11,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 20,
                    FromLocationId = 11,
                    ToLocationId = 10,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 11 → Location 12
                // -----------------------------------------

                new Navigation
                {
                    Id = 21,
                    FromLocationId = 11,
                    ToLocationId = 12,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 22,
                    FromLocationId = 12,
                    ToLocationId = 11,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 12 → Location 13
                // -----------------------------------------

                new Navigation
                {
                    Id = 23,
                    FromLocationId = 12,
                    ToLocationId = 13,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 24,
                    FromLocationId = 13,
                    ToLocationId = 12,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 13 → Location 14
                // -----------------------------------------

                new Navigation
                {
                    Id = 25,
                    FromLocationId = 13,
                    ToLocationId = 14,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 26,
                    FromLocationId = 14,
                    ToLocationId = 13,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 14 → Location 15
                // -----------------------------------------

                new Navigation
                {
                    Id = 27,
                    FromLocationId = 14,
                    ToLocationId = 15,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 28,
                    FromLocationId = 15,
                    ToLocationId = 14,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                },


                // -----------------------------------------
                // Location 15 → Location 16
                // -----------------------------------------

                new Navigation
                {
                    Id = 29,
                    FromLocationId = 15,
                    ToLocationId = 16,
                    Pitch = 0,
                    Yaw = 0,          // EDIT THIS
                    Direction = "Forward"
                },

                new Navigation
                {
                    Id = 30,
                    FromLocationId = 16,
                    ToLocationId = 15,
                    Pitch = 0,
                    Yaw = 180,        // EDIT THIS
                    Direction = "Backward"
                }
            );
        }
    }
}