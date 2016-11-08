//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace BasisMap.Models.DBContext
//{
//    public class InMemoryDBContext : DbContext
//    {
     
//            public InMemoryDBContext(DbContextOptions<InMemoryDBContext> options)
//                : base(options)
//            {
//            }



//            public DbSet<CommodityViewModel> CommodityList { get; set; }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<CommodityViewModel>(entity =>
//            {
//                modelBuilder.Entity<CommodityViewModel>().ToTable("Commodity");
//                modelBuilder.Entity<CommodityViewModel>().HasKey(c => c.Oid);
//                //.HasName("PK_Commodity");
//            });
//        }
//        public static void AddTestData(InMemoryDBContext context)
//        {

//            var cvm = new Models.CommodityViewModel
//            {
//                Oid = "1",
//                Code = "01",
//                Description = "Corn"
//            };
//            cvm = new Models.CommodityViewModel
//            {
//                Oid = "2",
//                Code = "02",
//                Description = "Wheat"
//            };
//            cvm = new Models.CommodityViewModel
//            {
//                Oid  = "3",
//                Code = "03",
//                Description = "Soybeans"
//            };


//            context.CommodityList.Add(cvm);
//            context.SaveChanges();
//        }

//    }
    
//}
