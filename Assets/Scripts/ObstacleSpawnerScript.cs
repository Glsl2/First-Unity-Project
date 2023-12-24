using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    private GameObject gameStateManager;
    public new Transform transform;
    public GameObject prefab;

    private bool isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(spawnObject), 0.1f, 0.9f);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void spawnObject() {
        if (!isGameOver) {
            GameObject obstacle = Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
