using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.API.Model
{
    public class CatalogItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string CatalogType { get; set; }

        public string CatalogBrand { get; set; }

        public int AvailableStock { get; set; }

        public bool OnReorder { get; set; }
    }
}
