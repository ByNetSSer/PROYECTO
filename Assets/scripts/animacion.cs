using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion : MonoBehaviour
{
    public Animator animacion_;
    public SpriteRenderer renderer_;
    public GameObject Damage;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Awake()
    {
        animacion_ = GetComponent<Animator>();
        renderer_ = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        animacion_.SetInteger("ismovingx", (int)vertical);
        animacion_.SetInteger("ismovingy", (int)horizontal);

        if (horizontal< 0 )
        {
            renderer_.flipX = true;
        }
        else if (horizontal > 0)
        {
            renderer_.flipX = false;
        }
        
        if (Input.GetKeyDown("k") && animacion_.GetBool("ispunch")!= true)
        {
            animacion_.SetBool("ispunch", true);
            animacion_.SetInteger("rndpunch", (int)Random.Range(1, 3));
        }
        
    }
    
    void notpunch()
    {
        animacion_.SetBool("ispunch", false);
        animacion_.SetInteger("rndpunch", 0);
    }
    void notstun()
    {
        animacion_.SetBool("in damage", false);
    }
    void CreateDamage()
    {
        if (renderer_.flipX)
        {
            Instantiate(Damage, new Vector2(transform.position.x - 0.4f, transform.position.y - 0.35f), transform.rotation);
        }
        else
        {
            Instantiate(Damage, new Vector2(transform.position.x + 0.4f, transform.position.y - 0.35f), transform.rotation);
        }
        
    }
    private void FixedUpdate()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Damage") {
            animacion_.SetBool("in damage", true);
        }
    }
}
