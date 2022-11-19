using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject botoes;
    public GameObject[] btn;  
 
    [SerializeField]
    int totalBtn = 0;
    [SerializeField]
    int QtdCorretos = 0;

    
    [SerializeField]
    private Animator porta;
    
    [SerializeField]
    private AudioSource portaCaindo;
    [SerializeField]

   // private Animator luz2;



    
    // Start is called before the first frame update
    void Start()
    {
       
        portaCaindo = GetComponent<AudioSource>(); 
        porta = GetComponent<Animator>();
       
       // luz2 = GetComponent<Animator>();

       //luz.SetBool("p",false);
       

        totalBtn = botoes.transform.childCount;
        btn = new GameObject[totalBtn];

        for(int i = 0; i < btn.Length; i++){
            btn[i]= botoes.transform.GetChild(i).gameObject;
        }
        
    }

   
    public void correctMove(){
    QtdCorretos +=1;
    if(QtdCorretos == totalBtn){
       
       // luz.SetBool("p",true);
        portaCaindo.Play();
        porta.SetBool("portaC",true);
         // luz.SetTrigger("p2");
        Debug.Log("vc conseguiu a frase");
        
    }
   }

   public void wrongMove(){
    QtdCorretos -= 1;
    
   }
}
