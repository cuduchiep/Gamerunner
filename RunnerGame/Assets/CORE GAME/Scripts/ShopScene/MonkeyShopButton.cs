using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonkeyShopButton : MonoBehaviour
{
    public Image image;
    public GameObject lockImage;
    private Button button;
    public bool canBuy = true;
    public int index;

    private void Start()
    {
        canBuy = true;
        button = GetComponent<Button>();
        button.onClick.AddListener(buttonPressed);
    }

    private void buttonPressed()
    {
        if (canBuy == false) return;

        UIShopController.Instance.imageChooseBuy.sprite = ClientGame.Instance.listSprites[index];
        UIShopController.Instance.popupBuy.SetActive(true);
        UIShopController.Instance.prizeText.text = ClientGame.Instance.prizes[index].ToString();
        UIShopController.Instance.indexChoose = index;
    }
}
