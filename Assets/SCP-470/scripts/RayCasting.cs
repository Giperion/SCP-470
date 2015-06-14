using UnityEngine;
using System.Collections;

public class RayCasting : MonoBehaviour {
    public Ray ray;
    public RaycastHit hit;
	
	void Start ()
	{
	ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
	}
    void Update() {
        if (Physics.Raycast(ray, out hit, 100))
            Debug.DrawLine(ray.origin, hit.point);
        
    }
}