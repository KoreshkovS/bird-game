using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    [SerializeField] private float _spawnRate;
    [SerializeField] private float _heightOffset;


    private float timer = 0;

    void Start()
    {
        SpawnPipe();
    }

    void Update()
    {
        if (timer < _spawnRate)
        {
            timer += Time.deltaTime;
        } else
        {
            SpawnPipe();
            timer = 0;
        }
       
    }

    public void SpawnPipe()
    {
        float lowestPoint = transform.position.y - _heightOffset;
        float highestPoint = transform.position.y + _heightOffset;
        Instantiate(_pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
