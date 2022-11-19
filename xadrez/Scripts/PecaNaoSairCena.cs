using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PecaNaoSairCena : MonoBehaviour
{
    public GameObject dama;
    private bool mover;
    private bool ficar;

    private float startX;
    private float startY;

    private Vector3 resetPos;

    void Start()
    {
        resetPos = this.transform.localPosition;
    }

    
    void Update()
    {
        if(ficar == false){
        if(mover)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startX, mousePos.y - startY, this.gameObject.transform.localPosition.z);
        }
        }
    }
    //metado para mover o objeto
    private void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startX = mousePos.x - this.transform.localPosition.x;
            startY = mousePos.y - this.transform.localPosition.y;

            mover = true;
        }
    }
//metado para verificar se deu o cheque mate
    private void OnMouseUp(){
      mover = false;
     
        if(Mathf.Abs(this.transform.localPosition.x - dama.transform.localPosition.x)<= 0.2f &&
        Mathf.Abs(this.transform.localPosition.y - dama.transform.localPosition.y)<= 0.2f)
        {
             this.transform.localPosition = new Vector3(0.937f,0.431f,0.7450141f);
             ficar= true;
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPos.x,resetPos.y,resetPos.z);//se nao for a posicao lo rei, volta para o lugar de origem
        }
       

    }
}

