using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Mountain : MonoBehaviour
{
    [SerializeField]
    protected float speed;

    public Transform Spawn_Mountain;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speed * -1 / 10, 0f));
    }


    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Destroy_")
        {
            Destroy(gameObject);
        }
    }
}
