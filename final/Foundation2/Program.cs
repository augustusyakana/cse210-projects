using System;

class Program
{
    static void Main(string[] args)
    {
        string pName1 = "Phone";
        int pID1 = 101;
        double pPrice1 = 250.50;
        int pQty1 = 1;
        Product phone = new Product(pName1, pID1, pPrice1, pQty1);

        string pName2 = "Laptop";
        int pID2 = 102;
        double pPrice2 = 1525.55;
        int pQty2 = 1;
        Product laptop = new Product(pName2, pID2, pPrice2, pQty2);

        string pName3 = "Charger";
        int pID3 = 103;
        double pPrice3 = 25.99;
        int pQty3 = 2;
        Product charger = new Product(pName3, pID3, pPrice3, pQty3);

        string pName4 = "USB Drive";
        int pID4 = 104;
        double pPrice4 = 55.89;
        int pQty4 = 2;
        Product usb = new Product(pName4, pID4, pPrice4, pQty4);

        string pName5 = "Hard Drive";
        int pID5 = 105;
        double pPrice5 = 152.75;
        int pQty5 = 5;
        Product drive = new Product(pName5, pID5, pPrice5, pQty5);

        string pName6 = "Monitor";
        int pID6 = 106;
        double pPrice6 = 257.32;
        int pQty6 = 3;
        Product monitor = new Product(pName6, pID6, pPrice6, pQty6);

        string pName7 = "Headphones";
        int pID7 = 107;
        double pPrice7 = 199.35;
        int pQty7 = 4;
        Product headphones = new Product(pName7, pID7, pPrice7, pQty7);
        
        string userName = "Augustus Yuki Yakana";
        string street = "1337 Aheahe Pl. Unit B";
        string city = "Wahiawa";
        string state = "Hawaii";
        string country = "USA";
        int zipcode = 96786;

        Customer customer = new Customer(userName);
        customer.AddCustomerAddress(street, city, state, country, zipcode);

        Order order1 = new Order(customer);
        order1.AddProducts(headphones);
        order1.AddProducts(phone);
        order1.AddProducts(charger);

        Console.WriteLine("\n(Order 1)");
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        Console.WriteLine(order1.GetTotalCost());

        string userName2 = "Prince Kimo Legend";
        string street2 = "691 NanPepper St.";
        string city2 = "Kolonia";
        string state2 = "Pohnpei";
        string country2 = "FSM";
        int zipcode2 = 96941;

        Customer customer2 = new Customer(userName2);
        customer2.AddCustomerAddress(street2, city2, state2, country2, zipcode2);

        Order order2 = new Order(customer2);
        order2.AddProducts(laptop);
        order2.AddProducts(monitor);
        order2.AddProducts(usb);
        order2.AddProducts(drive);

        Console.WriteLine("\n(Order 2)");
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        Console.WriteLine(order2.GetTotalCost());
        

    }
}