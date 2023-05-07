using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI coinText;

    private void Start()
    {
        coinText.text = ClientUser.Instance.amountCoin.ToString();
    }
}
