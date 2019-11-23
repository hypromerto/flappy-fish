using UnityEngine;

public class Ground : MonoBehaviour {

	[SerializeField]
	private float scrollSpeed = 5f;

	private Renderer rend;

	private void Awake()
	{
		rend = GetComponent<Renderer>();
	}
	// Update is called once per frame
	private void Update () 
	{
		Vector2 currentTextureOffset = rend.material.GetTextureOffset("_MainTex");
		float distanceToScrollLeft = Time.deltaTime * scrollSpeed;
		float newXoffset = currentTextureOffset.x + distanceToScrollLeft;

		Vector2 newOffset = new Vector2(newXoffset, currentTextureOffset.y);
		rend.material.SetTextureOffset("_MainTex", newOffset);
	}
}
