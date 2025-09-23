using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class spin : MonoBehaviour
{
    List<Transform> symbols = new List<Transform>();
    bool spinning = false;
    float elasped_time = 0;
    // Start is called before the first frame update
    void Start()
    {
        symbols = transform.GetComponentsInChildren<Transform>().ToList<Transform>();
        symbols.RemoveAt(0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!spinning) return;
        foreach (Transform t in symbols)
        {
            t.localPosition -= new Vector3(0, 0.2f, 0);
            if (t.localPosition.y <= -5.8)
            {
                t.localPosition += new Vector3(0, 7.1f, 0);

            }
        }
    }

    public void StopSpin()
    {
        spinning = false;
        float smallest_difference = Mathf.Infinity;
        foreach (Transform t in symbols)
        {
            float difference = -0.3f - t.position.y;
            if (Mathf.Abs(difference) < Mathf.Abs(smallest_difference))
            {
                smallest_difference = difference;
            }
        }
        foreach(Transform t in symbols)
        {
            t.localPosition += new Vector3(0, smallest_difference, 0);

        }
    }

    public void StartSpin()
    {
        elasped_time = 0;
        spinning = true;
    }
}
