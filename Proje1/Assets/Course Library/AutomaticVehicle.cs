using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticVehicle : MonoBehaviour
{
    //public float aktiflemeSuresi = 3.0f; // Aktifleþtirme süresi
    //public float speed = 10f;
    //Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    Invoke("Aktiflestir", aktiflemeSuresi); // Invoke kullanarak "Aktiflestir" fonksiyonunu belirtilen süre sonra çaðýr
    //}

    //void Aktiflestir()
    //{
    //    gameObject.SetActive(true); // Objeyi aktif hale getir
    //}


    public GameObject[] objeler; // Aktifleþtirilecek objelerin listesi
    public float aktiflemeSuresi = 3.0f; // Aktifleþtirme süresi
    private int siradakiObje = 0; // Sýradaki objenin indeksi

    void Start()
    {
        InvokeRepeating("Aktiflestir", aktiflemeSuresi, aktiflemeSuresi); // InvokeRepeating kullanarak "Aktiflestir" fonksiyonunu belirtilen süre aralýklarýyla çaðýr
    }

    void Aktiflestir()
    {
        objeler[siradakiObje].SetActive(true); // Sýradaki objeyi aktif hale getir
        siradakiObje++; // Sýradaki objenin indeksini bir sonraki objeye taþý
        if (siradakiObje >= objeler.Length) // Eðer son objeye ulaþtýysan sýfýrla
        {
            siradakiObje = 0;
        }
    }

}
