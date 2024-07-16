using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecipePanel : ItemPanel
{
    [SerializeField] RecipeList recipeList;

    public override void Show()
    {
        for(int i=0; i< buttons.Count && i <recipeList.recipes.Count; i++) 
        {
            buttons[i].Set(recipeList.recipes[i].output);
        }
    }
}
