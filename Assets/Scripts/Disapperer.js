#pragma strict

//var destroyTime : 5; // This is the time in seconds
function Start () {
    yield WaitForSeconds(2);
    Destroy(gameObject);
}

function Update () {

}