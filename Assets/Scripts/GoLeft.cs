using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoLeft : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    public void onDownLeft()
    {
        _pressed = true;
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
