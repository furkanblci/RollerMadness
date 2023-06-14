using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;  //hedef playerin transformunu tan�mlad���m�z yer
    [SerializeField] private float cameraFollowSpeed=5f;

    private Vector3 offsetVector;


    private void Start()
    {
        offsetVector =CalculateOffset(target); //calculateoffset methodundan direkt targetin offsetini �ekip tan�ml�yoruz

    }

    private void FixedUpdate() //tak�lmalar� engellemek i�in fixedupdate i�ine yaz�lmas� �nemlidir.
    {
        if (target != null) //nullreferance hatas�n� �nlemek i�in
        {
            MoveTheCamera();

        }

    }

    #region Temel Kamera takip sistemi
    private void MoveTheCamera()
    {
        Vector3 targetToMove = target.position + offsetVector;  // hedef playerin hareketini hesaplad���m�z kod

        transform.position = Vector3.Lerp(transform.position, targetToMove, cameraFollowSpeed * Time.deltaTime); //yumu�ak bir kamera takibini sa�lamak i�in yazm�� oldu�umuz kod

        transform.LookAt(target.transform.position); //kameran�n playeri takip etmesi i�in

    }
    #endregion

    #region Kamera takibini hesaplam�za yarayan kod(OOP �eklinde yaz�ld�)
    private Vector3 CalculateOffset(Transform newTarget)
    {
        return transform.position - newTarget.position; //kamera pozisyonundan Playerin pozisyonunu ��kartarak kamera takip mesafesini hesapl�yoruz.
    }
    #endregion


}
