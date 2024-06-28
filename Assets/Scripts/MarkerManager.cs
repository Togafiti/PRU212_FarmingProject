using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MarkerManager : MonoBehaviour
{
    [SerializeField] Tilemap targetTilemap; 
    [SerializeField] TileBase tile;
    public Vector3Int markerCellPosition;
     Vector3Int oldCellPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        targetTilemap.SetTile(oldCellPosition, null);
        targetTilemap.SetTile(markerCellPosition, tile);
        oldCellPosition= markerCellPosition;
    }
}
