using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kodlar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("EnYuksekSkor", 500);
        float enYuksek = PlayerPrefs.GetFloat("EnYuksekSkor");
        //print("En Yüksek Skor " + enYuksek);

        PlayerPrefs.SetInt("canSayisi", 10);
        // print(PlayerPrefs.GetInt("canSayisi", 5));

        PlayerPrefs.SetString("OyuncuAdi", "Sümeyye Turhan");
        print(PlayerPrefs.GetString("OyuncuAdi","Oyuncu 1"));

       // PlayerPrefs.DeleteKey("OyuncuAdi");
        print(PlayerPrefs.GetString("OyuncuAdi", "Oyuncu 1"));

        PlayerPrefs.DeleteAll();
        print(PlayerPrefs.GetString("OyuncuAdi", "Oyuncu 2"));
        print(PlayerPrefs.GetFloat("EnYuksekSkor", 999));
    }

}
