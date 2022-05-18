using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObj : MonoBehaviour
{
    public GameObject column;
    public float maxTime;
    public float high;
    float times;

    private void Start()
    {
        times = maxTime;
    }
    private void Update()
    {
        if (times > maxTime)
        {
            GameObject cl = Instantiate(column, new Vector2(transform.position.x, transform.position.y + Random.Range(-high, high)), Quaternion.identity);
            Destroy(cl, 9f);

            times = 0;

        }

        times += Time.deltaTime;
    }
}
