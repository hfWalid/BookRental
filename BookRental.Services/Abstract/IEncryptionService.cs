﻿
namespace BookRental.Services
{
    public interface IEncryptionService
    {
        string CreateSalt();

        string EncryptPassword(string password, string salt);
    }
}