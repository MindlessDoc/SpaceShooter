using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoPlay : MonoBehaviour
{
    [SerializeField] private Button _goPlay;
    // Start is called before the first frame update
    void Start()
    {
        _goPlay.onClick.AddListener(GoToGameScene);
    }
    private void GoToGameScene()
    {
        SceneManager.LoadScene(0);
    }
}
