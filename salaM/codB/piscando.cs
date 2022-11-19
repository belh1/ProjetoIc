using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piscando : MonoBehaviour
{
    public Light luz;

   public float veloMax;
   public float veloMin;
   public bool verificar;


  

  // public AudioSoure audio;
    void Start()
    {
        verificar = true;
    }

    void Update(){
        if(verificar==true){
            StartCoroutine(piscandoluz());
            verificar=false;
        }
    }

    // Update is called once per frame
   
    IEnumerator piscandoluz(){
        while(true){
            yield return new WaitForSeconds(Random.Range(veloMin,veloMax));
            luz.enabled=!luz.enabled;
            verificar=true;
           // audio.Play();
        }
    }
  
   
    
}
