using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolbarPanel : ItemPanel
{
    [SerializeField] ToolBarController ToolBarController;

    private void Start()
    {
        Init();
        ToolBarController.onChange += HightLight;
        HightLight(0);
    }

    public override void OnClick(int id)
    {
        ToolBarController.Set(id);
        HightLight(id);
    }

    int currentSelectedTool;

    public void HightLight(int id)
    {
        buttons[currentSelectedTool].HightLight(false); currentSelectedTool = id;
        buttons[currentSelectedTool].HightLight(true);
    }
}
