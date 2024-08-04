﻿using PasswordStorageApp.Domain.Enums;
using PasswordStorageApp.Domain.Models;

public class AccountUpdateDto
{
    public Guid Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public AccountType Type { get; set; }

    public Account ToAccount(Account account)
    {
        account.Username = Username;
        account.Password = Password;
        account.Type = Type;
        account.MofifiedOn = DateTime.UtcNow;

        return account;
    }
}