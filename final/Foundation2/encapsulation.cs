using System;
using System.Collections.Generic;

class Product {
    public string Name { get; set; }
    public int ProductId { get; set; }
    public double Price { get; set; }

    public int Quantity { get; set; }

    public double TotalCost {
        get { return Price * Quantity; }
    }
}

class Address {
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public bool IsInUSA() {
        return Country.ToLower() == "usa";
    }

    public string GetFullAddress() {
        return $"{Street}, {City}, {State}, {Country}";
    }
}

class Customer {
    public string Name { get; set; }
    public Address Address { get; set; }

    public bool IsInUSA() {
        return Address.IsInUSA();
    }
}

class Order {
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order() {
        Products = new List<Product>();
    }

    public double CalculateTotalCost() {
        double totalCost = 0;
        foreach (var product in Products) {
            totalCost += product.TotalCost;
        }

        return totalCost + (Customer.IsInUSA() ? 5 : 35);
    }

    public string GetPackingLabel() {
        string label = "Packing Label:\n";
        foreach (var product in Products) {
            label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return label;
    }

    public string GetShippingLabel(){
        return $"Shipping Label:\n{Customer.Name}\n{Customer.Address.GetFullAddress()}";
    }
}