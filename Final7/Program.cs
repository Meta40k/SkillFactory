﻿using Final7.Class;

internal class Program
{
    private static void Main(string[] args)
    {
        //Взяли на работу двух курьеров.
        List<Courier> Bedolagi = new List<Courier>();
        Courier Biba = new Courier();
        Courier Boba = new Courier();
        Bedolagi.Add(Biba);
        Bedolagi.Add(Boba);
        
        //Регистрируем двух пользователей
        Buyer Denis = new Buyer();
        
        //Все создаваемые ордеры, попадют в эту очередь
        List<Order> outline = new List<Order>();
        //Outline outline = new Outline();

    }
}