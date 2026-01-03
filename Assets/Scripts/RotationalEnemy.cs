using UnityEngine;

public class RotationalEnemy : Enemy
{
    // Variables Declaration
    [SerializeField] private float RotationSpeed = 100f;

    // Override Behaviour Method
    public override void Behaviour()
    {
        transform.Translate(Vector3.back * EnemySpeed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.up * Time.deltaTime * RotationSpeed);
    }
}
