using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    [SerializeField] private float stopDistance=1f; //takip mesafesinin sonunu belirlediðimiz yer
    private Transform target;
    [SerializeField] private GameObject deadEffect;



    private void Start()
    {
      
            target = GameObject.FindWithTag("Player").GetComponent<Transform>(); //hedef playerin transformuna eriþtim
 

    }

    private void Update()
    {
        if (target!=null) //null referans hatasýný çözmek için
        {
            transform.LookAt(target); //enemy'nin playera bakmasý için gereken kod

            float distance = Vector3.Distance(transform.position, target.position); //enemy'nin playeri takip mesafesini hesapladýðým yer
            if (distance > stopDistance)
            {
                transform.position += transform.forward * enemySpeed * Time.deltaTime; //takip mesafesinin durma mesafesinnden büyük olduðu durumda enemy'nin hareketini saðlayan kod
            }

        }   
       
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
           TimeManager timeManager=FindObjectOfType<TimeManager>(); //findobjectoftype kullanarak time managere eriþtim ve bir alt satýrda public olan gameoverý çektim
            timeManager.gameOver= true;
        }
    }

    
    
    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);

    }
}