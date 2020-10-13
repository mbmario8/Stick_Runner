using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    //Score
    private float score;

    public TextMeshProUGUI mesh;

    // Start is called before the first frame update
    void Start()
    {
        mesh = FindObjectOfType<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        displayScore();
    }


    //ChangeScore
    void displayScore()
    {
        mesh.text = "" + (int)score;
    }

    

}

