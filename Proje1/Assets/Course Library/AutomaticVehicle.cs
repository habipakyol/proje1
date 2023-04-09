using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticVehicle : MonoBehaviour
{
    //public float aktiflemeSuresi = 3.0f; // Aktifle�tirme s�resi
    //public float speed = 10f;
    //Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //    Invoke("Aktiflestir", aktiflemeSuresi); // Invoke kullanarak "Aktiflestir" fonksiyonunu belirtilen s�re sonra �a��r
    //}

    //void Aktiflestir()
    //{
    //    gameObject.SetActive(true); // Objeyi aktif hale getir
    //}


    public GameObject[] objeler; // Aktifle�tirilecek objelerin listesi
    public float aktiflemeSuresi = 3.0f; // Aktifle�tirme s�resi
    private int siradakiObje = 0; // S�radaki objenin indeksi

    void Start()
    {
        InvokeRepeating("Aktiflestir", aktiflemeSuresi, aktiflemeSuresi); // InvokeRepeating kullanarak "Aktiflestir" fonksiyonunu belirtilen s�re aral�klar�yla �a��r
    }

    void Aktiflestir()
    {
        objeler[siradakiObje].SetActive(true); // S�radaki objeyi aktif hale getir
        siradakiObje++; // S�radaki objenin indeksini bir sonraki objeye ta��
        if (siradakiObje >= objeler.Length) // E�er son objeye ula�t�ysan s�f�rla
        {
            siradakiObje = 0;
        }
    }

}
