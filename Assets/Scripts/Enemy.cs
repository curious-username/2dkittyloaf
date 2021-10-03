using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float _speed = 4.0f;
    private Player _player;
    [SerializeField]
    private GameObject _explosion;
    

    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        if(_player == null)
        {
            Debug.Log("_player null");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        EnemyMovement();

    }

    private void EnemyMovement()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
        if (gameObject.transform.position.y < -5.6f)
        {
            
            Destroy(gameObject);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(_player != null)
            {

                _player.Damage();
            }
            
            Destroy(gameObject);

        }

        if(collision.tag == "PlayerWeapon")
        {

            
            Destroy(gameObject);
            Instantiate(_explosion, transform.position, Quaternion.identity);
            
        }

    }

}
