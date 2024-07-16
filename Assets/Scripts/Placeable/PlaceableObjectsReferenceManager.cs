using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceableObjectsReferenceManager : MonoBehaviour
{
    public PlacableObjectsManager placableObjectsManager;

    public void Place(Item item, Vector3Int pos)
    {
        if(placableObjectsManager == null)
        {
            return;
        }

        placableObjectsManager.Place(item, pos);
    }

    public bool Check(Vector3Int position)
    {
        if(placableObjectsManager == null) 
        {
            Debug.Log("No placeableObjectManager reference detected");
            return false; 
        }

        return placableObjectsManager.Check(position);

    }

    internal void PickUp(Vector3Int gridPosition)
    {
        if (placableObjectsManager == null)
        {
            Debug.Log("No placeableObjectManager reference detected");
            return;
        }
        placableObjectsManager.PickUp(gridPosition);
    }
} 
