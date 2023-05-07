using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button ShopBtn;
    [SerializeField] private Button ConquestBtn;
    [SerializeField] private Button PlayGame;
    [SerializeField] private Button skinButton;             

    private void Start()
    {
        ShopBtn.onClick.AddListener(BtnShop);
        PlayGame.onClick.AddListener(BtnPlayGame);
        ConquestBtn.onClick.AddListener(BtnConquest);
        skinButton.onClick.AddListener(skinPressed);
    }
    private void BtnShop()
    {
        SceneManager.LoadScene(Scenes.ShopScene.ToString());
    }
    private void BtnConquest()
    {
        //SceneManager.LoadScene("PlayGame");
    }
    private void BtnPlayGame()
    {
        SceneManager.LoadScene(Scenes.Level1.ToString());
    }
    private void skinPressed()
    {
        SceneManager.LoadScene(Scenes.SkinScene.ToString());
    }
}
