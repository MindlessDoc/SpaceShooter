using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoUp : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    public void onDownUp()
    {
        _pressed = true;
    }

    public void onUpUp()
    {
        _pressed = false;
    }
    
    void Update()
    {
        if (_pressed)
            _player.Moving(Vector3.up);
    }
}
