using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obs_Move : MonoBehaviour
{

    [SerializeField]
    protected float speed = 5f;
    [SerializeField]
    protected float timeDestroy = 20f;


    // Update is called once per frame
    void Update()
    {
        //move para esquerda
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        //Destroy após o tempo
        Destroy(gameObject, timeDestroy);
        
    }
}
