using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mariposaSumi : MonoBehaviour
{
    
    public GameObject mariposa;
    bool pegar;
    public Light iluminacao;


    void Start ()
    {
        pegar=false;
        iluminacao.enabled = false;
    }
    
    void Update ()
    {
        if(pegar == true){
          if(Input.GetMouseButtonDown(0))
        {
            print("pegou mariposa");
            Destroy(mariposa);
            iluminacao.enabled = true;
    }

}
    }
void OnMouseEnter(){
print ("clicaste-me!");
pegar = true;

}
    
}
 


