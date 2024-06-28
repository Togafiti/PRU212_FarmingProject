using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileMapReadController : MonoBehaviour
{
    [SerializeField] Tilemap tilemap;
    [SerializeField] List<TileData> tileDatas;
    Dictionary<TileBase, TileData> dataFromTile;
    private void Start()
    {
        dataFromTile = new Dictionary<TileBase, TileData>();    
        foreach(TileData tiledata in tileDatas)
        {
            foreach (TileBase tile in tiledata.tiles)
            {
                dataFromTile.Add(tile,tiledata);
            }
        }
    }
    public void Update()
    {
        
        
    }
    public Vector3Int GetGridPosition(Vector2 position, bool mousePosition)
    {
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
        
        TileBase tile= tilemap.GetTile(gridPostion);

        Debug.Log("Tile Postion=" + gridPostion + " is " + tile);
        return tile;
    }
    public TileData GetTileData(TileBase tilebase) { 

        return dataFromTile[tilebase];
    }
}
