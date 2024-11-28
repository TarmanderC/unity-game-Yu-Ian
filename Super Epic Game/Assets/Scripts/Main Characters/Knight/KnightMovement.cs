using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    public float speed = 5f;
    public Animator anim;
    public SpriteRenderer sp;
    void Start()
    {
        
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical);

        transform.position += direction * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            sp.flipX = true;
            anim.SetFloat("isMoving", 1);
        } else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            sp.flipX = false;
            anim.SetFloat("isMoving", 1);
        } else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
            anim.SetFloat("isMoving", 1);
        } else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
            anim.SetFloat("isMoving", 1);
        } else {
            anim.SetFloat("isMoving", 0);
        }
    }
}
