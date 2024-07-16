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
        if (tilemap == null)
        {
            tilemap = GameObject.Find("BaseTilemap").GetComponent<Tilemap>();
            if (tilemap == null)
            {
                Debug.LogError("Tilemap is not found. Make sure there is a GameObject named 'BaseTilemap' with a Tilemap component.");
                return Vector3Int.zero;
            }
        }

        Vector3 worldPosition;
        if (mousePosition)
        {
            worldPosition = Camera.main.ScreenToWorldPoint(position);
        }
        else
        {
            worldPosition = position;
        }

        Vector3Int gridPosition = tilemap.WorldToCell(worldPosition);
        Debug.Log($"Mouse Position: {position}, World Position: {worldPosition}, Grid Position: {gridPosition}");

        return gridPosition;
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
