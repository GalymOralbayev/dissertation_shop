using System;

namespace Shop.DataAccess.Models {
    public class RecData
    {
        public int Id { get; set; }
        public int ProductFromId { get; set; }
        public int ProductToId { get; set; }
    }
}