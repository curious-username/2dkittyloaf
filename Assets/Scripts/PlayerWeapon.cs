using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    private float _speed = 8.0f;        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);

        if(gameObject.transform.position.y > 5.3)
        {
            Destroy(gameObject);
        }
        
    }
}
