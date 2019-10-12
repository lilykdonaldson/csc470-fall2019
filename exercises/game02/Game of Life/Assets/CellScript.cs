using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellScript : MonoBehaviour
{
	public bool alive = false;
	public bool nextAlive;
	bool prevAlive;
	public int x = -1;
	public int y = -1;

	Renderer renderer;

	// Start is called before the first frame update
	void Start()
    {
		prevAlive = alive;
	}

    // Update is called once per frame
    void Update()
    {
		if (prevAlive != alive) {
			updateColor();
		}

		prevAlive = alive;
	}

	public void updateColor()
	{
		if (renderer == null) {
			renderer = gameObject.GetComponent<Renderer>();
		}
        if(IsEqual(transform.position.y,0f))
        {
            transform.localScale += new Vector3(0, 0.9f, 0);
            Vector3 temp = new Vector3(0, 0.45f, 0);
            transform.position += temp;
        }

        if (this.alive) {
            transform.localScale += new Vector3(0, 1.5f, 0);
            Vector3 temp = new Vector3(0, 0.75f, 0);
            transform.position += temp;
            //if((
            int test = (int)System.Math.Round(transform.position.y)%2;
            if (test == 0)
            {
                renderer.material.color = new Color(210f / 255f, 180f / 255f, 140f / 255f);
            }
            else
            {
                renderer.material.color = new Color(195f / 255f, 164f / 255f, 103f / 255f);
            }
        } else {
            transform.localScale += new Vector3(0, -0.9f, 0);
            Vector3 temp = new Vector3(0, -0.45f, 0);
            transform.position += temp;
            int test = (int)System.Math.Round(transform.position.y) % 2;
            if (test == 0)
            {
                renderer.material.color = new Color(188f / 255f, 144f / 255f, 85f / 255f);
            }
            else
            {
                renderer.material.color = new Color(210f / 255f, 192f / 255f, 139f / 255f);
            }
        }
	}

	private void OnMouseDown()
	{
		alive = !alive;
	}




private bool IsEqual(float a, float b)
{
    if (a >= b - Mathf.Epsilon && a <= b + Mathf.Epsilon)
    {
        return true;
    }
    else
    {
        return false;
    }
}
}