using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinButton : MonoBehaviour
{
    public Image image;
    public int index = -1;
    public bool canClick;

    Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        canClick = false;

        button.onClick.AddListener(buttonPressed);
    }

    private void buttonPressed()
    {
        if (!canClick) return;


    }
}
