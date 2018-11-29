using CantinaApp.Core.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.ApplicationServices
{
    public interface IIngredientsServices
    {
        Ingredients GetIngredientsInstance();

        List<Ingredients> GetIngredients();

        Ingredients AddIngredient(Ingredients ingredient);

        Ingredients DeleteIngredient(int id);

        Ingredients FindIngredientId(int id);

        Ingredients UpdateIngredient(Ingredients ingredientUpdate);
    }
}
