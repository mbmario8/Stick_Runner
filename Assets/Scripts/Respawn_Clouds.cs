using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn_Clouds : MonoBehaviour
{
    //timer
    private float cloudTimer;
    [SerializeField]
    protected float Tempo;

    //instancias/prefabs
    public GameObject cloud01, cloud02, cloud03;


    private void Update()
    {
        ManagerTimer();
    }







    private void CriaNuvens()
    {
        

            //Sorteia numeros aleatorios para selecao de objstaculo
            float randomNumber = Random.Range(1, 5);
            //sumona o obstaculo sorteado
            if (randomNumber == 1)
            {
                Instantiate(cloud01, transform.position, transform.rotation);

            }
            else if (randomNumber == 2)
            {
                Instantiate(cloud02, transform.position, transform.rotation);
            }
            else if (randomNumber == 3)
            {
            Instantiate(cloud03, transform.position, transform.rotation);
            }



    }


    void ManagerTimer()
    {
        cloudTimer += Time.deltaTime;
        if (cloudTimer >= Tempo)
        {
            CriaNuvens();
            cloudTimer = 0;
        }
    }

}
