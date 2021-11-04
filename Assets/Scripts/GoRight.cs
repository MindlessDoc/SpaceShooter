using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoRight : MonoBehaviour
{
    [SerializeField] private Player _player;
    private bool _pressed = false;
    
    public void onDownRight()
    {
        _pressed = true;
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
