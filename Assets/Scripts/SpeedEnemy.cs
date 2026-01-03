using UnityEngine;

public class SpeedEnemy : Enemy
{
    public override void Behaviour()
    {
        transform.Translate(Vector3.back * Time.deltaTime * EnemySpeed);
    }
}
