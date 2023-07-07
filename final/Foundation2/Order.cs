using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        // Assigning the value of the customer parameter to the customer member variable of the class
        this._customer = customer;
        // Initialize products list
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        // Append product to the products list
        _products.Add(product);
    }

    public float CalculateTotalPrice()
    {
        float totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.CalculatePrice();
        }

        // Add shipping after the loop
        totalPrice += _customer.IsInUSA() ? 5 : 35;

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in _products)
        {
            packingLabel += $"Product Name: {product.Name}, Product ID: {product.ProductId}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "Shipping Label:\n";
        shippingLabel += $"Customer Name: {_customer.Name}\n";
        shippingLabel += _customer.GetAddressString();

        return shippingLabel;
    }
}