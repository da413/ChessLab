using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmosSelected()
    {
        int gridSize = 8;
        Gizmos.color = Color.black;
        for (int i = 0; i <= gridSize; i++)
        {
            Gizmos.DrawLine(new Vector3(i, 0, 0), new Vector3(i, gridSize, 0));
            Gizmos.DrawLine(new Vector3(0, i, 0), new Vector3(gridSize, i, 0));
        }
    }
}
