using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLeft : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    private float _prevtTimeClick;
    [SerializeField] private float _intervalOnClick = 0.2f;

    void Start()
    {
        _prevtTimeClick = Time.timeSinceLevelLoad;
    }
    public void onDownLeft()
    {
        _pressed = true;
        if (Time.time - _prevtTimeClick <= _intervalOnClick)
        {
            _player.HyperMoving(Vector3.left);
        }
        _prevtTimeClick = Time.timeSinceLevelLoad;
    }

    public void onUpLeft()
    {
        _pressed = false;
    }
    
    void Update()
    {
        if (_pressed)
            _player.Moving(Vector3.left);
    }
}
