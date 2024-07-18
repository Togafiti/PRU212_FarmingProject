using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private string nameEssentialScene;
    [SerializeField] private string nameNewGameStartScene;
    [SerializeField] private GameObject menuCanvas; 

   

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public void StartNewGame()
    {
        
        SceneManager.LoadScene(nameNewGameStartScene, LoadSceneMode.Single);
        SceneManager.LoadScene(nameEssentialScene, LoadSceneMode.Additive);
    }

    private void ToggleMenu()
    {
        if (menuCanvas != null)
        {

            bool isActive = menuCanvas.activeSelf;
            menuCanvas.SetActive(!isActive); 
        }
    }
}
