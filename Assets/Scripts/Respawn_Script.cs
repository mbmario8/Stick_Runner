using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class Respawn_Script : MonoBehaviour
{

    //timer para sistema de respawn
    [SerializeField]
    protected float timer;
    [SerializeField]
    protected float tempo;

    //score
    public float score;


    //gameObj = instanciado
    public GameObject obj01, obj02, obj03;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        ManagerTimer();


        //score
        score += Time.deltaTime;
        DisplayScore();


    }

    //Nesse metodo temos o timer do respawn
    void ManagerTimer()
    {
        timer += Time.deltaTime;
        if(timer >= tempo)
        {
            AddObstacle();
            timer = 0;
        }
    }

    void AddObstacle()
    {

        //Sorteia numeros aleatorios para selecao de objstaculo
        float randomNumber = Random.Range(1 , 5);
        //sumona o obstaculo sorteado
        if(randomNumber == 1)
        {
            Instantiate(obj01, transform.position, transform.rotation);

        }else if(randomNumber == 2)
        {
            Instantiate(obj02, transform.position, transform.rotation);
        }else if(randomNumber == 3)
        {
            Instantiate(obj03, transform.position, transform.rotation);
        }
    }


    void DisplayScore()
    {
        GameObject.Find("ScoreUI").GetComponent<Text>().text = "" + (int)score;
    }



}


 