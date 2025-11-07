using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

public class Peon_Script : MonoBehaviour
{
    [SerializeField]
    public Input_Manager InputManager;
    Rigidbody2D rigid2D;
    [SerializeField]
    float walkSpeed = 6.0f;
    Animator animator;
    Vector2 pre_input;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        InputManager.Mouvement(rigid2D, animator, transform, walkSpeed);
    }
/*    public void FaceRight()
    {
        transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
    }

    public void FaceLeft()
    {
        transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
    }*/
}

