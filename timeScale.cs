using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeScale : MonoBehaviour
{
    
    public float speed;
    bool ff = false; // FAST FOWARD // 
    bool slowmo = false;  // SLOWMOTION //
    bool rt = false; // REAL TIME//


    // Update is called once per frame
    void Update()
    {
       checkUpdate();
    }

    void checkUpdate(){
         if(ff){
            Time.timeScale += speed/4;
            ff = false;
            Debug.Log("Time Scale : " + Time.timeScale);
        }
        else if(slowmo){
            Time.timeScale -= speed/4;
            slowmo = false;
            Debug.Log("Time Scale : " + Time.timeScale);
        }
        else if(rt){
            Time.timeScale = 1.0f;
            rt = false;
            Debug.Log("Time Scale : " + Time.timeScale);
        }
    }

    public void fastFoward(){
        ff = true;
    }

    public void slowmotion(){
        slowmo = true;
    }

    public void realTime(){
        rt = true;
    }
}   
