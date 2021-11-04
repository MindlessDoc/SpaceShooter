using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Player _player;
    
    [SerializeField] private Button _goLeft;
    [SerializeField] private Button _goRight;
    [SerializeField] private Button _goUp;
    [SerializeField] private Button _goDown;

    private Vector3 _direction = Vector3.zero;
    
    public void onDownLeft()
    {
        _direction = Vector3.left;
    }

    public void onUpLeft()
    {
        _direction = Vector3.zero;
    }
    
    public void onDownRight()
    {
        _direction = Vector3.right;
    }

    public void onUpRight()
    {
        _direction = Vector3.zero;
    }
    
    public void onDownDown()
    {
        _direction = Vector3.down;
    }

    public void onUpDown()
    {
        _direction = Vector3.zero;
    }
    
    public void onDownUp()
    {
        _direction = Vector3.up;
    }

    public void onUpUp()
    {
        _direction = Vector3.zero;
    }

    public void Update()
    {
        _player.Moving(_direction);
    }
}
