using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Block : MonoBehaviour
{
    private bool isColided = false; // playerin çarpýp çarpmadýðýný denetlemek için bool deðiþkeni oluþturdum.

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag=="Player" && isColided==false) 
        {
            GetComponent<MeshRenderer>().material.color = Color.red; //meshrendererin materyaline eriþip rengini deðiþtirdim.

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); //Score deðiþkenini kullanabilmek için için FindObjectOfType kullanarak ScoreManagerinin scriptine eriþtim. 
            scoreManager.score=scoreManager.score-3;
            isColided=true; //karakterin tekrar tekrar duvara çarpýp yukarýdaki kodlarý tekrarlamamasý için çarptý mý ya evet diyoruz.
        }

               
       
    }



}
