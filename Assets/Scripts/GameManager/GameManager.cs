using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    [SerializeField] ScreenTint ScreenTint;
    public GameObject player;
    public DialogueSystem dialogueSystem;
    public DayTimeController timeController;
    public ItemDragAndDropController dragAndDropController;
    public ItemContainer inventoryContainer;
}
