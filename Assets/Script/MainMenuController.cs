using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Create by Fidel Jeremy Wowiling");
    }

    public void OpenAuthor()
    {
        Debug.Log("Create by Fidel Jeremy Wowiling");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void CreditScene()
    {
        SceneManager.LoadScene("CreditScene");
    }
}


