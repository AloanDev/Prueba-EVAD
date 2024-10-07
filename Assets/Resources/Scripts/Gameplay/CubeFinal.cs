using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeFinal : MonoBehaviour
{
    private bool _collected;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        if (!_collected)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            _collected = true;
            GameManager.points = 0;
        }
    }
}