using UnityEngine;
using System.Collections;
[ExecuteInEditMode]
public class GLtest : MonoBehaviour {
	public Material mat;
	public Vector3 cubeoffset;
	public int arraystep;
    void OnPostRender() {
        if (!mat) {
            Debug.LogError("Please Assign a material on the inspector");
            return;
        }
        GL.PushMatrix(); //start openGL draw
        mat.SetPass(0); //set material to GL lines
		GL.LoadProjectionMatrix (GetComponent<Camera>().projectionMatrix); //load camera matrix
		//draw wireframe cube
		DrawCubeArray (0, 0, 0, arraystep);
        GL.PopMatrix(); //end openGL draw
		
    }
	
	public void DrawCube (float xOffset, float yOffset, float zOffset)
	{
		        				GL.Begin(GL.LINES);
		//cube code draw. Vertex doubled
        GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
        GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 0.25f line
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 2 line
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 3 line
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 4 line
        GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
        GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 0.25f line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 2 line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 3 line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 4 line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 0.25f connected line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0 + cubeoffset.z + zOffset);//end 2 connected line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0.25f + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 3 connected line
		GL.Vertex3 (0.25f + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);
		GL.Vertex3 (0 + cubeoffset.x + xOffset, 0 + cubeoffset.y + yOffset, 0.25f + cubeoffset.z + zOffset);//end 4 connected line, finally
        					GL.End();
	}
	public void DrawCubeArray (float xOffset, float yOffset, float zOffset, int arraystep)
	{
		float xOffset2 = xOffset;
		float yOffset2 = yOffset;
		float zOffset2 = zOffset;
		for (int i = 0; i < arraystep; i++)
		{
			DrawCube (xOffset2, yOffset2, zOffset2);
			xOffset2 += 0.25f;
		}
	}
}
