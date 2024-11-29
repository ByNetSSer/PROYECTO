using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion_E : MonoBehaviour
{
    public Animator animacion_;

    // Start is called before the first frame update
    void Awake()
    {
        animacion_ = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NotDamage()
    {
        animacion_.SetBool("GetDamage", false);
    }
}
