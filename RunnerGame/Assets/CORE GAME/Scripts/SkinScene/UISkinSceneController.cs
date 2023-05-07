using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UISkinSceneController : MonoBehaviour
{
    [Header("Button")]
    public List<GameObject> listButton;

    private void Start()
    {
        int tmp = 0;
        foreach(var child in ClientUser.Instance.monkeyHas)
        {
            var button = listButton[tmp].GetComponent<SkinButton>();
            button.image.sprite = ClientGame.Instance.listSprites[child];
            button.canClick = true;
            button.index = child;
            tmp++;
        }
    }
}
