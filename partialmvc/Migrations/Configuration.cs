namespace partialmvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<partialmvc.Models.PartialContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PartialContext context)
        {
            CreateCategory(context);
        }
        private void CreateCategory(PartialContext context)
        {
            if (context.Categorys.Count() == 0)
            {
                var category = new List<Category>()
                {
                       new Category()
                       {
                           Name="Banh",
                           Description="Ngon re"

                       },
                       new Category()
                       {
                           Name="Keo",
                           Description="Ngon"
                       },
                       new Category()
                       {
                           Name="Mi",
                           Description="Bo dinh duong"
                       }
                };
                context.Categorys.AddRange(category);
                context.SaveChanges();
            }
        }
    }
}
