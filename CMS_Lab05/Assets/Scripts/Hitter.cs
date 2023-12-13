using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class Hitter : MonoBehaviour
{
    void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.layer != 6)
                {
                    return;
                }
                Vector3 force = (hit.transform.position - Camera.main.transform.position).normalized * 300;
                hit.collider.gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
            }
        }
    }
}
