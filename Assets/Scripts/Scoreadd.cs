using UnityEngine;
using System.Collections.Generic;

public class Scoreadd : MonoBehaviour
{
    public int scoreValue = 1;
    public int Score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            
            Score += scoreValue;
            Debug.Log(Score);
        }
    }

    


}


