﻿using BookRental.DataModels;

namespace BookRental.DataAccess.Configurations
{
    public class RentalConfiguration : EntityBaseConfiguration<Rental>
    {
        public RentalConfiguration()
        {
            Property(r => r.CustomerId).IsRequired();
            Property(r => r.StockId).IsRequired();
            Property(r => r.Status).IsRequired().HasMaxLength(10);
            Property(r => r.ReturnedDate).IsOptional();
        }
    }
}
