using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDragAndDropController : MonoBehaviour
{
    [SerializeField] ItemSlot itemSlot;
    [SerializeField] GameObject itemIcoin;
    RectTransform iconTransform;
    Image image;
    private void Start()
    {
        itemSlot = new ItemSlot();
        iconTransform = itemIcoin.GetComponent<RectTransform>();
        image = itemIcoin.GetComponent<Image>();
    }
    private void Update()
    {
        if(itemIcoin.activeInHierarchy == true)
        {
            iconTransform.position = Input.mousePosition;

            if(Input.GetMouseButtonDown(0))
            {
                if(EventSystem.current.IsPointerOverGameObject() == false )
                {
                    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    worldPosition.z = 0;
                    ItemSpawnManager.instance.SpawnItem(worldPosition, itemSlot.item, itemSlot.count);

                    itemSlot.Clear();
                    itemIcoin.SetActive(false);
                }
            }
        }
    }
    internal void OnClick(ItemSlot itemSlot)
    {
        if(this.itemSlot.item == null)
        {
            this.itemSlot.Copy(itemSlot);
            itemSlot.Clear();
        }
        else
        {
            Item item = itemSlot.item;
            int count =itemSlot.count;

            itemSlot.Copy(this.itemSlot);
            this.itemSlot.Set(item, count); 
        }
        UpdateIcoin();
    }

    private void UpdateIcoin()
    {
        if(itemSlot.item == null) { 
            itemIcoin.SetActive(false);
        } else{
            itemIcoin.SetActive(true);
            image.sprite = itemSlot.item.icon;
        }
    }
}
