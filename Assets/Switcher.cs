using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Switcher : MonoBehaviour
{
     
    public GameObject[] Cameras;
     
    int current;
     
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
        setCam(current);
    }
 
    // Update is called once per frame
    void Update()
    {
         
    }
     
    public void setCam(int num){
        for(int i = 0; i < Cameras.Length; i++){
            if(i == num){
                Cameras[i].SetActive(true);
            }else{
                Cameras[i].SetActive(false);
            }
        }
    }
     
    public void switchCam(){
        current++;
        if(current > Cameras.Length-1)
            current = 0;
        setCam(current);
    }
}