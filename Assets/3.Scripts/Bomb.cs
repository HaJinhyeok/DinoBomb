using System.Collections;
using UnityEngine;


public class Bomb : MonoBehaviour
{
    public float Speed = 3f;

    void Start()
    {
        // Destroy(gameObject, 5f);
        StartCoroutine(CoDeactivate());
    }

    void Update()
    {
        transform.Translate(Vector3.down * Speed * Time.deltaTime);
    }

    IEnumerator CoDeactivate()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}
