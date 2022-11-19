using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cod : MonoBehaviour
{
  bool mouse;
  void Start () {
print ("olá, a aplicação começou!");
mouse=false;
}
 
// Update is called once per frame
void Update () {
  if(mouse == true){//se mouse for igual a true
    if(Input.GetMouseButtonDown(0)){//e se clicar com o mause
      transform.Rotate(0,0,200*Time.deltaTime);//rotacione o objeto no eixo z(vira o botao)
    }
  }
}

 
void OnMouseEnter(){
print ("clicaste-me!");
mouse = true;

}
void OnMouseExit(){
  mouse = false;
  print ("nao clicou no botao!");
}
   
}
