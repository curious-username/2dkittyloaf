using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 4.0f;
    [SerializeField]
    private GameObject _playerWeaponPreFab;
    [SerializeField]
    private int _lives = 3;
 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CalculateMovement();
        if (Input.GetKeyDown(KeyCode.Space)){
            FireWeapon();
        }

    }

    private void CalculateMovement()
    {
        float _horizontalInput = Input.GetAxis("Horizontal");
        float _verticalInput = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector2(_horizontalInput, _verticalInput);
        transform.Translate(direction * _speed * Time.deltaTime);

    }

    private void FireWeapon()
    {
        Instantiate(_playerWeaponPreFab, transform.position, Quaternion.identity);
    }

    public void Damage()
    {
        _lives--;

        if (_lives == 0){
             
                Destroy(gameObject);
            }
            
            
        }
    }



