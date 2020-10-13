using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    //Apenas possui código de movimento
    [SerializeField]
    protected float speed;
    [SerializeField]
    protected float timeDestroy;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        Destroy(gameObject, timeDestroy);
    }
}
