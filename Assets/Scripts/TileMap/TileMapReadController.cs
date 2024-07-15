using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapReadController : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    public CropsManager cropsManager;

    public Vector3Int GetGridPosition(Vector2 position, bool mousePosition)
    {
        if(tilemap == null)
        {
            tilemap = GameObject.Find("BaseTilemap").GetComponent<Tilemap>();
        }

        if (tilemap == null) 
        { 
            return Vector3Int.zero;
        }

        Vector3 worldPostion;
        if (mousePosition)
        {
            worldPostion = Camera.main.ScreenToWorldPoint(position);

        }
        else
        {
            worldPostion = position;
        }

        Vector3Int gridPostion = tilemap.WorldToCell(worldPostion);
        return gridPostion;
    }

    public TileBase GetTileBase(Vector3Int gridPostion)
    {
        if (tilemap == null)
        {
            tilemap = GameObject.Find("BaseTilemap").GetComponent<Tilemap>();
        }

        if (tilemap == null)
        {
            return null;
        }

        TileBase tile= tilemap.GetTile(gridPostion);

        Debug.Log("Tile Position=" + gridPostion + " is " + tile);
        return tile;
    }
}
