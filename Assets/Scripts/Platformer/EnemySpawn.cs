using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private Enemy _template;
    [SerializeField] private int _count;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private float _spawnDistance;
    [SerializeField] private Transform _parent;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        var waitForSecond = new WaitForSeconds(_spawnDelay);

        for (int i = 0; i < _count; i++)
        {
            var createEnemy = Instantiate(_template, Vector3.zero, Quaternion.identity, _parent);

            Transform newEnemyTransform = createEnemy.GetComponent<Transform>();

            newEnemyTransform.position = new Vector3(_spawnDistance * i, -3.85f, 0);

            yield return waitForSecond;
        }
    }
}
