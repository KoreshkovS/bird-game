using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _deadZone;

    void Update()
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed * Time.deltaTime);

        if (transform.position.y < _deadZone)
        {
            Destroy(gameObject);

        }
    }
}
