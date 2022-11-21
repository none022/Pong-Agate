using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpPaddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public Collider2D paddleLeft;
    public Collider2D paddleRight;

    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            paddleLeft.GetComponent<PaddleController>().ScaleUp();
            paddleRight.GetComponent<PaddleController>().ScaleUp();
            manager.RemovePowerUp(gameObject);
        }
    }
}

