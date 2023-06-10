using UnityEngine;
using System.Collections.Generic;

public class BallLauncher : MonoBehaviour
{
    public float launchForce = 5f; 
    public GameObject ball; 
    private Vector2 initialMousePos;
    private Rigidbody2D ballRigidbody;

    private int score = 0;

    private void Start()
    {
        ballRigidbody = ball.GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        initialMousePos = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        
        Vector2 direction = initialMousePos - (Vector2)Input.mousePosition;

        
        Debug.DrawLine(ball.transform.position, ball.transform.position + (Vector3)direction, Color.red);
    }

    private void OnMouseUp()
    {
        
        Vector2 force = (initialMousePos - (Vector2)Input.mousePosition) * launchForce;

      
        ballRigidbody.AddForce(force, ForceMode2D.Impulse);
    }

   
}

