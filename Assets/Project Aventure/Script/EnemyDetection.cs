using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [Header("Value")]
    [SerializeField] private float alertRange;
    [SerializeField] private float enemySpeed;

    [Header("General")]
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private Transform playerPosition;       

    private bool isAlert;
    
    private void Update()
    {
        isAlert = Physics.CheckSphere(transform.position, alertRange, playerMask);

        if (isAlert == true)
        {
            Vector3 playerPlacement = new Vector3(playerPosition.position.x, transform.position.y, playerPosition.position.z);

            transform.LookAt(playerPlacement);
            transform.position = Vector3.MoveTowards(transform.position, playerPlacement, enemySpeed * Time.deltaTime);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, alertRange);
    }
}
