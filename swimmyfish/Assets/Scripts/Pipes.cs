using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed=5f;
    private float leftEdge;

    private void Start(){
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x -1f;//issue with just this is that pipes are pivoted around 
        //center point so it'll get destroyed before fully off screen
    }

    private void Update(){
        transform.position+= Vector3.left*speed*Time.deltaTime;
        if(transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }
}
