using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject statusPanel;
    [SerializeField] GameObject toolBarPanel;
    [SerializeField] GameObject storePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if(panel.activeInHierarchy == false)
            {
                Open();
            } 
            else
            {
                Close();
            }
        }
    }

    public void Open()
    {
        panel.SetActive(true);
        statusPanel.SetActive(true);
        toolBarPanel.SetActive(false);
        storePanel.SetActive(false);
    }

    public void Close()
    {
        panel.SetActive(false);
        statusPanel.SetActive(false);
        toolBarPanel.SetActive(true);
        storePanel.SetActive(false);
    }
}
