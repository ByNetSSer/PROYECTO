using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_ : MonoBehaviour
{
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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigobase.vida < 1)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Hit")
        {
            enemigobase.getdamage();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
