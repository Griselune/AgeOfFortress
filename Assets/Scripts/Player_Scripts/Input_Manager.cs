using UnityEngine;

public class Input_Manager
{
    Vector2 pre_input;

    public void Mouvement(Rigidbody2D RB2D, Animator Anim, UnityEngine.Transform transform, float walkSpeed)
    {
        int keyX = 0;
        int keyY = 0;
        Anim.SetBool("isWalking", false);

        if (Input.GetKey(KeyCode.DownArrow))
        {
            keyY = -1;
            Anim.SetBool("isWalking", true);
            if (pre_input.y >= 0)
            {
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            keyY = 1;
            Anim.SetBool("isWalking", true);
            if (pre_input.y <= 0)
            {
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            keyX = -1;
            Anim.SetBool("isWalking", true);
            if (pre_input.x >= 0)
            {
                FaceLeft(transform);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            keyX = 1;
            Anim.SetBool("isWalking", true);
            if (pre_input.x <= 0)
            {
                FaceRight(transform);
            }
        }
        RB2D.linearVelocity = new Vector2(keyX * walkSpeed, keyY * walkSpeed);

        pre_input = new Vector2(keyX, keyY);
    }

    public void FaceRight(UnityEngine.Transform transform)
    {
        transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
    }

    public void FaceLeft(UnityEngine.Transform transform)
    {
        transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
    }
}