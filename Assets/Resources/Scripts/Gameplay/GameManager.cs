using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int points;

    public GameObject cubeFinal;
    
    void Update()
    {
        if (points >= 5)
        {
            cubeFinal.SetActive(true);
        }
    }

    public static void AddCoin()
    {
        points++;

    }

}
