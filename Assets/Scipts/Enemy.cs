using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float enemySpeed;
    [SerializeField] private float stopDistance=1f; //takip mesafesinin sonunu belirledi�imiz yer
    private Transform target;
    [SerializeField] private GameObject deadEffect;



    private void Start()
    {
      
            target = GameObject.FindWithTag("Player").GetComponent<Transform>(); //hedef playerin transformuna eri�tim
 

    }

    private void Update()
    {
        if (target!=null) //null referans hatas�n� ��zmek i�in
        {
            transform.LookAt(target); //enemy'nin playera bakmas� i�in gereken kod

            float distance = Vector3.Distance(transform.position, target.position); //enemy'nin playeri takip mesafesini hesaplad���m yer
            if (distance > stopDistance)
            {
                transform.position += transform.forward * enemySpeed * Time.deltaTime; //takip mesafesinin durma mesafesinnden b�y�k oldu�u durumda enemy'nin hareketini sa�layan kod
            }

        }   
       
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
           TimeManager timeManager=FindObjectOfType<TimeManager>(); //findobjectoftype kullanarak time managere eri�tim ve bir alt sat�rda public olan gameover� �ektim
            timeManager.gameOver= true;
        }
    }

    
    
    private void OnDisable()
    {
        Instantiate(deadEffect, transform.position, transform.rotation);

    }
}