using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = new Vector3(0, -3, 0);
    }
    public void Moving(Vector3 direction)
    {
        transform.Translate(direction * _speed * Time.deltaTime);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
