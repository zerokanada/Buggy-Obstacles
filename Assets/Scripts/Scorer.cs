using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score=100;

    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag != "Hit"){
            
            score-=10;
        } 
       
        
       
        Debug.Log("Your total score is " + score);
    }
    
    
}
