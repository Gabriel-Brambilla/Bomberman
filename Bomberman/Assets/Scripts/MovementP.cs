using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D { get; private set; }

    private Vector2 direction = Vector2.zero;

    public float speed = 5f;

    public KeyCode inputUp = KeyCode.W;
    public KeyCode inputDown = KeyCode.S;
    public KeyCode inputLeft = KeyCode.A;
    public KeyCode inputRight = KeyCode.D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }



    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(inputUp))
            this.SetDirection(Vector2.up);
        else if (Input.GetKey(inputDown))
            this.SetDirection(Vector2.down);
        else if (Input.GetKey(inputLeft))
            this.SetDirection(Vector2.left);
        else if (Input.GetKey(inputRight))
            this.SetDirection(Vector2.right);
        else
            this.SetDirection(Vector2.zero);
    }

    private void FixedUpdate()
    {
        Vector2 postion = rigidbody2D.position;
        Vector2 translation = direction * speed * Time.fixedDeltaTime;

        rigidbody2D.MovePosition(postion + translation);
    }

    private void SetDirection(Vector2 newDirection)
    {
        direction = newDirection;
    }
}
