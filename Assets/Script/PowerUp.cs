using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public float magnitude;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == ball)
        {
            ball.GetComponent<BallController>().ActivePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }

    private void Update()
    {
        //manager.Awake();
    }
}
