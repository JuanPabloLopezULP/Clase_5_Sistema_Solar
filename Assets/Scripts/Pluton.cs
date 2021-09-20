using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluton : MonoBehaviour
{
    private GameObject sol;
    // Start is called before the first frame update
    void Start()
    {
        sol = GameObject.FindGameObjectWithTag("Sol");
        transform.rotation = Quaternion.Euler(0, 0, 122);

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sol.transform.position, Vector3.up, 6 * Time.deltaTime);
        transform.Rotate(Vector3.up, 8 * Time.deltaTime);
    }
}
