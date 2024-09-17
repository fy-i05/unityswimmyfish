using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;
    private void Awake(){
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update(){
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed*Time.deltaTime, 0);//0 for y bc not moving bg in the y
    }
}
