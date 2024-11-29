using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_ : MonoBehaviour
{
    public animacion_E animacion_e;
    BoxCollider2D boxcolider_;
    class enemigo
    {
        public int vida;
        public enemigo()
        {
            vida =5;
        }
        public void getdamage()
        {
            vida = vida - 1;
        }
    }
    enemigo enemigobase = new enemigo();
    // Start is called before the first frame update
    void Awake()
    {
        boxcolider_ = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigobase.vida < 1)
        {
            animacion_e.animacion_.SetBool("Death", true);
            Destroy(this.gameObject, 8);
        }
        if (animacion_e.animacion_.GetBool("GetDamage"))
        {
            boxcolider_.enabled = false;
        }
        else
        {
            boxcolider_.enabled = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            animacion_e.animacion_.SetBool("GetDamage", true);
            enemigobase.getdamage();
        }
    }
}
