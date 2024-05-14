using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _velocidade;
    [SerializeField] Rigidbody2D _rb;
    [SerializeField] Vector2 _move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _move.x = Input.GetAxisRaw("Horizontal");
        _rb.velocity = new Vector2(_move.x * _velocidade, 0);
    }
}
