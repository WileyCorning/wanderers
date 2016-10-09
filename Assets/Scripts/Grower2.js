#pragma strict

function Start () {

}

var maxSize : float = 5.0;
var growthRate : float = 1.0;
var scale : float = 50.0;
 
function Update () 
{
    transform.localScale = Vector3.one * scale;
    scale += growthRate * Time.deltaTime;
    if (scale > maxSize) Destroy (gameObject);
}