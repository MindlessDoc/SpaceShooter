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
        transform.position = new Vector3(0, -2.5f, 0);
    }
    public void Moving(Vector3 direction)
    {
        Vector3 additional = direction * _speed * Time.deltaTime;
        Vector3 goIn = additional + transform.position;
        if(goIn.y >= -2.5f && goIn.y <= 0.0f && goIn.x >= -2.2f && goIn.x <= 2.2f)
            transform.Translate(additional);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
