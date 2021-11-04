using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoDown : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    public void onDownDown()
    {
        _pressed = true;
    }

    public void onUpDown()
    {
        _pressed = false;
    }
    
    void Update()
    {
        if (_pressed)
            _player.Moving(Vector3.down);
    }
}
