using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    public Vector3 RightPosition;
    public bool InRighPosition;
    public bool Selected;

    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(-1.96f, 2.04f), Random.Range(-1.42f, -4.94f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, RightPosition) < 0.2f)
        {
            if (!Selected)
            {
                if (InRighPosition == false)
                {

                    transform.position = RightPosition;
                    InRighPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                }
            }

        }
    }
}
