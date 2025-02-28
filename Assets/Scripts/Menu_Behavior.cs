using UnityEngine;
using UnityEditor;
using System.Collections;

public class Menu_Behavior : MonoBehaviour
{
    public void goToGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}
