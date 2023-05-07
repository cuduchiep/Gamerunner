using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopSceneController : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private Button nextButton;

    private void Start()
    {
        backButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(Scenes.MainMenu.ToString());
        });

        nextButton.onClick.AddListener(NextButtonPressed);
    }

    private void NextButtonPressed()
    {

    }
}
