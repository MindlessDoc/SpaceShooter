using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FragmentsScore : MonoBehaviour
{
    [SerializeField] private Text _score;
    void Start()
    {
        _score.text = PlayerPrefs.GetInt("Fragment").ToString();
    }

    // Update is called once per frame
    public void UpdateScore()
    {
        _score.text = PlayerPrefs.GetInt("Fragment").ToString();
    }
}
