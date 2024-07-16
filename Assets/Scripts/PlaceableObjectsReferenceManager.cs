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
} 
