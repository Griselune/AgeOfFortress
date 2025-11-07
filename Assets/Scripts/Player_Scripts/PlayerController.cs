using UnityEngine;
using UnityEngine.InputSystem;



public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 5.0f;
    Vector2 pre_input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        int keyX = 0;
        int keyY = 0;


        rigid2D.linearVelocity = new Vector2(keyX * walkForce, keyY * walkForce);

        pre_input = new Vector2(keyX, keyY);
    }
}
