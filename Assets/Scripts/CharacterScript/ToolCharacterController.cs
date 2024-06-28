using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolCharacterController : MonoBehaviour
{
    CharacterController character;
    Rigidbody2D rigidbody2d;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 1.2f;
    [SerializeField] MarkerManager markerManager;
    [SerializeField] TileMapReadController tileMapReadController;
    private void Awake()
    {
        character = GetComponent<CharacterController>();
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Mark();
        if(Input.GetMouseButtonDown(0))
        {
            UseTool();
        }
    }

    private void Mark()
    {
       Vector3Int gridPosition= tileMapReadController.GetGridPosition(Input.mousePosition,true);    
        markerManager.markerCellPosition = gridPosition;
    }

    private void UseTool()
    {
        Vector2 position = rigidbody2d.position + character.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach(Collider2D collider in colliders)
        {
            ToolHit hit = collider.GetComponent<ToolHit>();
            if(hit != null )
            {
                hit.Hit();
                break;
            }
        }
    }
}
