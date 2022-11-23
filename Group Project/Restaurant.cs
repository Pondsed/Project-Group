using System.Collections.Generic;
using System;
public class Restaurant{
    private string restaurantName;
    private List<FoodMenu>foodmenu;
    public Restaurant(string restaurantName){
        this.restaurantName = restaurantName;
        this.foodmenu = new List<FoodMenu>();
    }
    public string GetRestaurantName() {
        return this.restaurantName;
    }

    public void GetFoodMenu() {
        Console.WriteLine("----------------------");
        foreach(FoodMenu foodMenu in this.foodmenu){
            Console.WriteLine("{0} : {1} , {2} Baht",foodMenu.GetFoodName(),foodMenu.GetNormalPrice(),foodMenu.GetHighPrice());
        }
    }

}   