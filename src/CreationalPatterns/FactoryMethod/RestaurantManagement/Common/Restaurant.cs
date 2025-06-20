﻿namespace RestaurantManagement.Common;

/// <summary>
/// The Creator class declares the factory method that returns new product objects.
/// 餐馆
/// </summary>
public abstract class Restaurant
{
    /// <summary>
    /// The factory method that returns new product objects.
    /// It’s important that the return type of this method matches the product interface.
    /// You can declare the factory method as abstract to force all subclasses to implement their own versions of the method.
    /// As an alternative, the base factory method can return some default product type.
    /// </summary>
    /// 准备主菜
    /// <returns>Meal.</returns>
    public abstract IMeal PrepareMainCourse();

    /// <summary>
    /// Note, despite its name, product creation is not the primary responsibility of the creator. 
    /// Usually, the creator class already has some core business logic related to products.
    /// The factory method helps to decouple this logic using the concrete product classes.
    /// 每日特供
    /// </summary>
    public void OrderDailySpecial()
    {
        Console.WriteLine("Drink: sparkling water");

        var mainCourse = PrepareMainCourse();
        mainCourse.ShowDescription();
    }
}
