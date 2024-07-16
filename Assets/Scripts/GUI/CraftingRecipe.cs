using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

[Serializable]
public class RecipeElement
{
    public Item item;
    public int count;
}

[CreateAssetMenu(menuName ="Data/Recipe")]
public class CraftingRecipe : ScriptableObject
{
    public List<ItemSlot> elements;
    public ItemSlot output;
}
