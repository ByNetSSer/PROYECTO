using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform player;
    public float speed;
    Enemigo_ scriptenemigo;
    public float distanciaminima;
    // Start is called before the first frame update
    void Awake()
    {
        scriptenemigo = GetComponent<Enemigo_>();
    }

    // Update is called once per frame
    void Update()
    {
        if (scriptenemigo.animacion_e.animacion_.GetBool("Death") != true && Vector2.Distance(transform.position,player.position)>distanciaminima)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
            
    }
}
