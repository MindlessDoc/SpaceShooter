using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _hyperSpeed = 50.0f;
    
    [SerializeField] private float _hyperMoveInterval;
    private float _prevHyperMove;

    [SerializeField] private Button _shootButton;
    [SerializeField] private GameObject _lazerPrefab;
    
    private float _nextFire;
    [SerializeField] private float _rateFire;

    [SerializeField] private AudioClip _boom;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        transform.position = new Vector3(0, -2.0f, 0);
        _shootButton.onClick.AddListener(Shoot);
        _nextFire = Time.time;
        _prevHyperMove = Time.time;
    }
    public void Moving(Vector3 direction)
    {
        Vector3 additional = direction * _speed * Time.deltaTime;
        Vector3 goIn = additional + transform.position;
        if(goIn.y >= -2.0f && goIn.y <= 0.5f && goIn.x >= -2.0f && goIn.x <= 2.0f && this.gameObject)
            transform.Translate(additional);
    }
    
    public void HyperMoving(Vector3 direction)
    {
        Vector3 additional = direction * _hyperSpeed * Time.deltaTime;
        Vector3 goIn = additional + transform.position;
        if (goIn.y >= -2.0f && goIn.y <= 0.5f && goIn.x >= -2.0f && goIn.x <= 2.0f && this.gameObject 
            && Time.time - _prevHyperMove >= _hyperMoveInterval)
        {
            _prevHyperMove = Time.time;
            transform.Translate(additional);
        }
    }

    private void Shoot()
    {
        if (_nextFire <= Time.time)
        {
            Vector3 laserSpawn = transform.position;
            laserSpawn.y += 0.6f;
            Instantiate(_lazerPrefab, laserSpawn, Quaternion.identity);
            _nextFire = Time.time + _rateFire;
        }
    }

    public void Die()
    {
        AudioSource.PlayClipAtPoint(_boom, transform.position, 1.0f);
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
