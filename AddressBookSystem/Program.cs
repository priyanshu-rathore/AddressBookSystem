﻿namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddressBookRepo add = new AddressBookRepo();
            add.AddContacts();
        }
    }
}