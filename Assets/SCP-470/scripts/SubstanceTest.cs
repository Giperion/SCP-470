using UnityEngine;
using System.Collections;

public class SubstanceTest : MonoBehaviour { //Для теста с динамическими текстурами. Добывает параметр и анимирует его
	public string PropertyName = "BadassTexture";
	private float test = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	ProceduralMaterial substance = GetComponent<Renderer>().sharedMaterial as ProceduralMaterial;
	if (Input.GetKeyDown (KeyCode.O))
	{
	test += 0.05f;
	substance.SetProceduralFloat (PropertyName,  test);
	substance.RebuildTextures ();
	}
	if (Input.GetKeyDown (KeyCode.P))
		{
		test -= 0.05f;
		substance.SetProceduralFloat (PropertyName,  test);
		substance.RebuildTextures ();
		}
	}
}
