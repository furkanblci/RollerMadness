using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Block : MonoBehaviour
{
    private bool isColided = false; // playerin �arp�p �arpmad���n� denetlemek i�in bool de�i�keni olu�turdum.

    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag=="Player" && isColided==false) 
        {
            GetComponent<MeshRenderer>().material.color = Color.red; //meshrendererin materyaline eri�ip rengini de�i�tirdim.

            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); //Score de�i�kenini kullanabilmek i�in i�in FindObjectOfType kullanarak ScoreManagerinin scriptine eri�tim. 
            scoreManager.score=scoreManager.score-3;
            isColided=true; //karakterin tekrar tekrar duvara �arp�p yukar�daki kodlar� tekrarlamamas� i�in �arpt� m� ya evet diyoruz.
        }

               
       
    }



}
