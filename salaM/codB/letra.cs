using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class letra : MonoBehaviour
{
    float[] rotacoes = {0,90,180,270};
    public float posicaoCorreta;

    [SerializeField]
    bool correto = false;

    private AudioSource girarBnt;
   

    
    GameManager game;

    private void Awake(){
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
            }

    void Start()
    {
        girarBnt = GetComponent<AudioSource>(); 
      transform.eulerAngles = new Vector3(0,rotacoes.Length);


         if(transform.eulerAngles.z == posicaoCorreta){
            correto=true;
           game.correctMove();
           
        }
        
    }

    private void OnMouseDown(){
        girarBnt.Play();
        transform.Rotate(new Vector3(0,0,90));


        if(transform.eulerAngles.z == posicaoCorreta && correto == false){
            correto=true;
           game.correctMove();
        }
        else if(correto == true){
            correto = false;
            game.wrongMove();
        }
    }
    
}
