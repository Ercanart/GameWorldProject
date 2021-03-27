using GameWorldProject.İnterfaces;
using GameWorldProject.PropertyClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameWorldProject.MethodClasses
{
    class GameManager : IGameService
    {
        public void Add(Game game)
    {
        Console.WriteLine(game.Name + " Adlı oyun " + game.Price + " satış fiyatıyla oyun veritabanına eklendi.");
    }

    public void Delete(Game game)
    {
        Console.WriteLine(game.Name + " Adlı oyun, oyun veritabanından silindi.");
    }

    public void Update(Game game)
    {
        Console.WriteLine(game.Name + " Adlı oyun " + game.Price + " satış fiyatıyla oyun veritabanına guncellendi.");
    }
}
}
