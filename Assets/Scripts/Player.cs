using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    //Variavel de controle do pulo
    private bool isGround;
    //Components
    private Rigidbody2D rb2d;
    private Animator anim;

    //ForceJump
    [SerializeField]
    protected float forceJump;

    //Variaveis para acesso do Controlador de botões
    //GameObject btPause, btResume, btExit, GamePausedText;
    public bool paused;


    // Start is called before the first frame update
    void Start()
    {
        //Iniciando Componentes
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();



        









        //Codigo Referente ao controlador de botões
        /*paused = false;
        GamePausedText = GameObject.Find("Paused_Label");
        btResume = GameObject.Find("Resume_Button");
        btExit = GameObject.Find("Exit_Button");
        btResume = GameObject.Find("Resume_Button");*/


    }
    

    // Update is called once per frame
    void Update()
    {

















        //Funcao pular + botão do pulo (Space)
        if (Input.GetMouseButtonDown(0) && isGround) 
        {
            Jump();            
        }
    }

    void OnCollisionEnter2D(Collision2D coll) 
    { 
    
        if(coll.gameObject.tag == "Ground")
        {
            isGround = true;
            anim.SetBool("Jump", false);
            anim.SetBool("Ground", true);
        }
        else
        {
            isGround = false;
        
        }
        
        if(coll.gameObject.tag == "Obs")
        {
            SceneManager.LoadScene("Lvl01");
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Change")
        {
            anim.SetBool("Jump", false);
        }
    }


    //metodo do pulo
    void Jump()
    {

        rb2d.AddForce(new Vector2(0 , forceJump), ForceMode2D.Impulse);

        anim.SetBool("Jump", true);
        anim.SetBool("Ground", false);
        isGround = false;
    }



    //Controlador de botoes

    /*public void pause()
    {
        paused = true;
        displayPauseButtons(true);

        Time.timeScale = 0;
 
    }*/

    /*void displayPauseButtons(bool state)
    {
        GamePausedText.SetActive(state);
        btResume.SetActive(state);
        btExit.SetActive(state);
        btPause.SetActive(!state);
    }
    */
    /*public void resume()
    {
        Time.timeScale = 1;
        displayPauseButtons(false);
    }*/
}
