using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 35f;
    [SerializeField]private float Boundary = 21f;
    private void Update()
    {
        PlayerMovement();
        BoundaryCheck();
    }

    private void PlayerMovement()
    {
        // Move the player with arrow keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void BoundaryCheck()
    {
        // Keep the player within the defined boundaries
        if (transform.position.x < -Boundary)
        {
            transform.position = new Vector3(-Boundary, transform.position.y, transform.position.z);
        }
        if (transform.position.x > Boundary)
        {
            transform.position = new Vector3(Boundary, transform.position.y, transform.position.z);
        }
    }
}
