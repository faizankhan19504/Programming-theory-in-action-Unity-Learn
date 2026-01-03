using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Variables Declaration
    private float lowerZBound = 12f;
    public float EnemySpeed = 2f;
    private void Update()
    {
        BoundaryCheck();
        Behaviour();
    }
    // Boundary Check Method
    private void BoundaryCheck()
    {
        if (transform.position.z < -lowerZBound)
        {
            Debug.Log("Enemy went out of bounds and is destroyed.");
            Destroy(gameObject);
        }
    }
    
    // Virtual Behaviour Method
    public virtual void Behaviour()
    {
        transform.Translate(Vector3.down * Time.deltaTime * EnemySpeed);
    }
}
