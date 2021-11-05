using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopContent : MonoBehaviour
{
    private int _money;
    public Sprite YesCheckAchievement;
    public Sprite NoCheckAchievement;
    private Image Image;

    public string[] ArrayTitles;
    public int[] ArrayValues;
    public GameObject Model;

    private List<GameObject> _list = new List<GameObject>();

    void Start()
    {
        _money = PlayerPrefs.GetInt("money");

        setAchievs();
    }

    void setAchievs()
    {
        RectTransform rectTransform = GetComponent<RectTransform>();
        rectTransform.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
        if (ArrayTitles.Length > 0)
        {
            GameObject NewModel = Instantiate(Model, transform);
            RectTransform rT = GetComponent<RectTransform>();
            rT.sizeDelta = new Vector2(rT.rect.width, NewModel.GetComponent<RectTransform>().rect.height * ArrayTitles.Length);
            Destroy(NewModel);
            for (int i = 0; i < ArrayTitles.Length; i++)
            {
                GameObject ListModel = Instantiate(Model, transform);
                ListModel.GetComponentInChildren<Text>().text = ArrayTitles[i];
                if(ArrayValues[i] <= _money)
                    ListModel.GetComponentInChildren<Image>().sprite = YesCheckAchievement;
                else
                    ListModel.GetComponentInChildren<Image>().sprite = NoCheckAchievement;
                _list.Add(ListModel);
            }
        }
    }
}