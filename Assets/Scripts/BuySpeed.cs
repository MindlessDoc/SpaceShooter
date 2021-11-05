using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuySpeed : MonoBehaviour
{
    [SerializeField] private Button _buy;
    [SerializeField] private int _price = 20;

    void Start()
    {
        if (PlayerPrefs.GetInt("Lazerx2") == 1 || PlayerPrefs.GetInt("Fragment") < 20)
        {
            _buy.interactable = false;
        }
        _buy.onClick.AddListener(Buy);
    }

    private void Buy()
    {
        if (PlayerPrefs.GetInt("Fragment") >= 20)
        {
            PlayerPrefs.SetFloat("PlayerSpeed", 4.0f);
            PlayerPrefs.SetFloat("Fragment", PlayerPrefs.GetInt("Fragment") - 20);
        }
    }
}
