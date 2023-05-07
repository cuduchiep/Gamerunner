using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerSceneController : MonoBehaviour
{
    private void Start()
    {
        SceneManager.LoadScene(Scenes.MainMenu.ToString());
    }
}
