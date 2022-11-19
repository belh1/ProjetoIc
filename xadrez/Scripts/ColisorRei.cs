using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorRei : MonoBehaviour
{
  Animator rei;
  void Start(){
      rei = GetComponent<Animator>();
  }
   
  
  private void OnTriggerEnter2D(Collider2D collision){
       if(collision.gameObject.tag == "Player"){//se a tag player colidir com o rei
            rei.SetBool("derrubar",true);//faz a animação de derrubar o rei
       }

  }

}
