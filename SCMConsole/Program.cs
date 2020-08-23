using System;
using System.Collections.Generic;

namespace SCMConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> cartProducts = new Dictionary<string, string>();
            cartProducts.Add("A", "5"); //adding a key/value using the Add() method
            cartProducts.Add("B", "4");
            cartProducts.Add("C", "1");
            cartProducts.Add("D", "1");
            cartProducts.Add("E", "1");


            string configAllProducts = System.Configuration.ConfigurationManager.AppSettings["products"];
            IDictionary<string, string> lstProducts = new Dictionary<string, string>();

            string[] arrProducts = configAllProducts.Split(",");

            foreach (var prod in arrProducts)
            {
                lstProducts.Add(prod.Split("^")?[0], prod.Split("^")?[1]);
            }

            string separeteItemPromo = System.Configuration.ConfigurationManager.AppSettings["separeteItemPromo"];
            string percDiscountSeparateItemPromo = System.Configuration.ConfigurationManager.AppSettings["percDiscountSeparateItemPromo"];

            string combinedItemsPromo = System.Configuration.ConfigurationManager.AppSettings["combinedItemsPromo"];
            string percDiscountCombinedItemsPromo = System.Configuration.ConfigurationManager.AppSettings["percDiscountCombinedItemsPromo"];

            string[] arrSepareteItemPromo = separeteItemPromo.Split("^"); //3*A=130^2*B=45
            string[] arrPercDiscountSeparateItemPromo = percDiscountSeparateItemPromo.Split("^"); //2E=10%
            string[] arrCombinedItemsPromo = combinedItemsPromo.Split("^"); //C+D=30
            string[] arrPercDiscountCombinedItemsPromo = percDiscountCombinedItemsPromo.Split("^"); //D+E=15%

        }
    }
}
