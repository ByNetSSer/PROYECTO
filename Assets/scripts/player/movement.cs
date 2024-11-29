using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Transform transform_;
    Rigidbody2D rigid_;
    public float horizontal;
    public float vertical;
    public animacion _animacion;
    // Start is called before the first frame update
    void Awake()
    {
        transform_ = GetComponent<Transform>();
        rigid_ = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_animacion.animacion_.GetBool("ispunch") != true)
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");
        }
        else{
            rigid_.velocity = new Vector2(0, 0);
        }
        
    }
    
    private void FixedUpdate()
    {
        if (_animacion.animacion_.GetBool("ispunch") != true)
        { 
            rigid_.velocity = new Vector2(horizontal, vertical*0.6f); 
        }     
    }
}
