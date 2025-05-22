using Commodity_Request_Form.Enums;
using Commodity_Request_Form.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Commodity_Request_Form.Data
{
    public class SeedData
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            // Seed CHAs
            modelBuilder.Entity<CHA>().HasData(
                new CHA { CHA_ID = 1, F_Name = "Alice", L_Name = "Kamau" },
                new CHA { CHA_ID = 2, F_Name = "John", L_Name = "Otieno" },
                new CHA { CHA_ID = 3, F_Name = "Mary", L_Name = "Wangari" },
                new CHA { CHA_ID = 4, F_Name = "David", L_Name = "Mwangi" }
            );

            // Seed CHWs
            modelBuilder.Entity<CHW>().HasData(
                new CHW { CHW_ID = 1, F_Name = "Grace", L_Name = "Njeri", CHA_ID = 1 },
                new CHW { CHW_ID = 2, F_Name = "Peter", L_Name = "Otieno", CHA_ID = 2 },
                new CHW { CHW_ID = 3, F_Name = "Esther", L_Name = "Wangari", CHA_ID = 1 },
                new CHW { CHW_ID = 4, F_Name = "James", L_Name = "Mwangi", CHA_ID = 3 },
                new CHW { CHW_ID = 5, F_Name = "Faith", L_Name = "Nyaoga", CHA_ID = 4 },
                new CHW { CHW_ID = 6, F_Name = "Samuel", L_Name = "Kamau", CHA_ID = 1 },
                new CHW { CHW_ID = 7, F_Name = "Rebecca", L_Name = "Nyambura", CHA_ID = 1 },
                new CHW { CHW_ID = 8, F_Name = "David", L_Name = "Owino", CHA_ID = 1 },
                new CHW { CHW_ID = 9, F_Name = "Alice", L_Name = "Kilonzo", CHA_ID = 2 },
                new CHW { CHW_ID = 10, F_Name = "Michael", L_Name = "Otieno", CHA_ID = 2 },
                new CHW { CHW_ID = 11, F_Name = "Esther", L_Name = "Ochieng", CHA_ID = 3 },
                new CHW { CHW_ID = 12, F_Name = "Paul", L_Name = "Ndegwa", CHA_ID = 3 },
                new CHW { CHW_ID = 13, F_Name = "Joyce", L_Name = "Akinyi", CHA_ID = 4 },
                new CHW { CHW_ID = 14, F_Name = "Benjamin", L_Name = "Mwangi", CHA_ID = 4 }
            );

            // Seed Commodities
            modelBuilder.Entity<Commodity>().HasData(
                new Commodity { ID = 1, Name = "Malaria Drugs", Quantity = 50, DateRequested = new DateTime(2024, 05, 01), Status = RequestStatus.Approved, CHW_ID = 1, CHA_ID = 1 },
                new Commodity { ID = 2, Name = "Family Planning Items", Quantity = 30, DateRequested = new DateTime(2024, 03, 01), Status = RequestStatus.Approved, CHW_ID = 2, CHA_ID = 2 },
                new Commodity { ID = 3, Name = "Zinc Tablets", Quantity = 40, DateRequested = new DateTime(2024, 02, 10), Status = RequestStatus.Rejected, CHW_ID = 3, CHA_ID = 1 },
                new Commodity { ID = 4, Name = "Malaria Drugs", Quantity = 60, DateRequested = new DateTime(2024, 05, 15), Status = RequestStatus.Pending, CHW_ID = 4, CHA_ID = 3 },
                new Commodity { ID = 5, Name = "Family Planning Items", Quantity = 25, DateRequested = new DateTime(2024, 01, 11), Status = RequestStatus.Approved, CHW_ID = 5, CHA_ID = 4 }
            );
        }
    }
}
