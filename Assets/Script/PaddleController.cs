using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public PowerUpManager manager;
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;
    private Rigidbody2D rig;

    public GameObject paddleLeft;
    public GameObject paddleRight;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        //ambil input
        
        if (Input.GetKey(upKey))
        {
           return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }
    public void ScaleUp()
    {
        paddleLeft.transform.localScale = new Vector2(0.3064471f, 2.479323f * 2);
        paddleRight.transform.localScale = new Vector2(0.3064471f, 2.479323f * 2);
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(5);
        paddleLeft.transform.localScale = new Vector2(0.3064471f, 2.479323f);
        paddleRight.transform.localScale = new Vector2(0.3064471f, 2.479323f);

    }

    public void SpeedUp(float magnitude)
    {
        speed *= magnitude;
        StartCoroutine(waiter2());
    }

    IEnumerator waiter2()
    {
        yield return new WaitForSeconds(5);
        speed = 5;
    }


    public void ActivePaddleSpeedUp(float magnitude)
    {
        speed *= magnitude;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Kecepatan paddle : " + movement);
        //gerakan objek dengan input
        rig.velocity = movement;
    }
}
