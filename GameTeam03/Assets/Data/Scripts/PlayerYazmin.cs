using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class PlayerYazmin : MonoBehaviour
{
    
    
    public int vidaPlayer;
    public Slider sliderVida;

    

    private void Update()
    {

        sliderVida.GetComponent<Slider>().value = vidaPlayer;


        if (vidaPlayer <= 0)
        {
            Debug.Log("Fin del Juego");
            
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
    }

   

    public void LoadData()
    {
        GameData gameData = SaveManger.LoadPlayerData();
        vidaPlayer = gameData.vida;

        transform.position = new Vector3(gameData.position[0], gameData.position[1], gameData.position[2]);
        Debug.Log("Datos Cargados");
       

    }

    public void SaveData()
    {
        SaveManger.SavePlayerData(this);
        Debug.Log("Datos Guardados");
    }

   

  
}
