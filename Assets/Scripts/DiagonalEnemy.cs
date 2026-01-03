using UnityEngine;

public class DiagonalEnemy : Enemy
{
    // Variables Declaration
    [SerializeField] private Vector3 DiagonalDirection = (Vector3.back + Vector3.left).normalized;

    // Override Behaviour Method
    public override void Behaviour()
    {
        transform.Translate(DiagonalDirection * Time.deltaTime * EnemySpeed);
    }
}
