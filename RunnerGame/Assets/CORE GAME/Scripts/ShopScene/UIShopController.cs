using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UIShopController : MonoBehaviour
{
    private static UIShopController instance;

    public static UIShopController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<UIShopController>(true);
            }
            return instance;
        }
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance.gameObject);
        }
        instance = this;
    }

    [Header("Popup buy")]
    public GameObject popupBuy;
    public Image imageChooseBuy;
    public TextMeshProUGUI prizeText;
    public Button confirmButton;

    public List<GameObject> listButton;
    public int indexChoose = -1;

    [Header("Popup Noti")]
    public GameObject successPopup;
    public GameObject failPopup;

    private void Start()
    {

        confirmButton.onClick.AddListener(confirmButtonPressed);

        foreach(var child in ClientUser.Instance.monkeyHas)
        {
            var tmp = listButton[child].GetComponent<MonkeyShopButton>();
            tmp.lockImage.SetActive(false);
            tmp.image.sprite = ClientGame.Instance.listSprites[child];
            tmp.canBuy = false;
        }
    }

    private void confirmButtonPressed()
    {
        popupBuy.SetActive(false);
        if (ClientGame.Instance.prizes[indexChoose] > ClientUser.Instance.amountCoin)
        {
            failPopup.SetActive(true);
            Debug.Log("1");
            return;
        }
        else
        {
            successPopup.SetActive(true);

            ClientUser.Instance.monkeyHas.Add(indexChoose);
            ClientUser.Instance.amountCoin -= ClientGame.Instance.prizes[indexChoose];
            Debug.Log("2");

            var tmp = listButton[indexChoose].GetComponent<MonkeyShopButton>();
            tmp.lockImage.SetActive(false);
            tmp.image.sprite = ClientGame.Instance.listSprites[indexChoose];
            tmp.canBuy = false;
            FindObjectOfType<CoinController>().coinText.text = ClientUser.Instance.amountCoin.ToString();
        }
    }
}
