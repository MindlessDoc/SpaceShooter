using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    private float _prevtTimeClick;
    [SerializeField] private float _intervalOnClick = 0.2f;
    
    public void onDownRight()
    {
        _pressed = true;
        if (Time.timeSinceLevelLoad - _prevtTimeClick <= _intervalOnClick)
        {
            _player.HyperMoving(Vector3.right);
        }
        _prevtTimeClick = Time.timeSinceLevelLoad;
    }

    public void onUpRight()
    {
        _pressed = false;
    }

    void Update()
    {
        if (_pressed)
        {
            _player.Moving(Vector3.right);
        }
    }
}
