﻿// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concsrote.InMemory;

ProductManager productManager = new ProductManager(new InMemoryProductDal());

foreach (var product in productManager.GetAll())
{

    Console.WriteLine(product.ProductName);
}

