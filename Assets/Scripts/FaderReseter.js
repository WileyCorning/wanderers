#pragma strict

var alpha : float = 0;

function Start () {

}

function Update () {
    lerpReset();
}

function lerpReset(){
    alpha = Mathf.Lerp(0.0, 1.0, 1.0) ;
    GetComponent.<Renderer>().material.color.a = alpha;
}