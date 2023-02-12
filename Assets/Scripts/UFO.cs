using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO : MonoBehaviour
{
    public Transform player;
    float speed = 1f;
    float step;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
    public void Destroy()

    {
        GameManager.Instance.UFODestroyed();
        GameObject.Destroy(this.gameObject);
    }
}
