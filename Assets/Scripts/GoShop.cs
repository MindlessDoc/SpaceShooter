using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoShop : MonoBehaviour
{
    [SerializeField] private Button _goShop;
    void Start()
    {
        _goShop.onClick.AddListener(ToShop);
    }

    private void ToShop()
    {
        SceneManager.LoadScene(3);
    }
}
