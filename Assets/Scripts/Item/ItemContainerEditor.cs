using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ItemContainer))]
public class ItemContainerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        ItemContainer itemContainer = (ItemContainer)target;
        if (GUILayout.Button("Clear container"))
        {
            for (int i = 0; i < itemContainer.slots.Count; i++)
            {
                itemContainer.slots[i].Clear();
            }
        }
        DrawDefaultInspector();
    }
}
