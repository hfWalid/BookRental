﻿using System;

namespace BookRental.DataModels
{
    public class Rental : IEntityBase
    {
        public int ID { get; set; }

        public int CustomerId { get; set; }

        public int StockId { get; set; }

        public virtual Stock Stock { get; set; }

        public DateTime RentalDate { get; set; }

        public Nullable<DateTime> ReturnedDate { get; set; }

        public string Status { get; set; }
    }
}
