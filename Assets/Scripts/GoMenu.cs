using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoMenu : MonoBehaviour
{
    [SerializeField] private Button _goMenu;
    void Start()
    {
        _goMenu.onClick.AddListener(ToMenu);
    }

    private void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
