using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;  //hedef playerin transformunu tanýmladýðýmýz yer
    [SerializeField] private float cameraFollowSpeed=5f;

    private Vector3 offsetVector;


    private void Start()
    {
        offsetVector =CalculateOffset(target); //calculateoffset methodundan direkt targetin offsetini çekip tanýmlýyoruz

    }

    private void FixedUpdate() //takýlmalarý engellemek için fixedupdate içine yazýlmasý önemlidir.
    {
        if (target != null) //nullreferance hatasýný önlemek için
        {
            MoveTheCamera();

        }

    }

    #region Temel Kamera takip sistemi
    private void MoveTheCamera()
    {
        Vector3 targetToMove = target.position + offsetVector;  // hedef playerin hareketini hesapladýðýmýz kod

        transform.position = Vector3.Lerp(transform.position, targetToMove, cameraFollowSpeed * Time.deltaTime); //yumuþak bir kamera takibini saðlamak için yazmýþ olduðumuz kod

        transform.LookAt(target.transform.position); //kameranýn playeri takip etmesi için

    }
    #endregion

    #region Kamera takibini hesaplamýza yarayan kod(OOP þeklinde yazýldý)
    private Vector3 CalculateOffset(Transform newTarget)
    {
        return transform.position - newTarget.position; //kamera pozisyonundan Playerin pozisyonunu çýkartarak kamera takip mesafesini hesaplýyoruz.
    }
    #endregion


}
