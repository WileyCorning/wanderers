#pragma strict
  
var duration : float = 1.0;
var alpha : float = 0;
  
function Update(){
    
    lerpAlpha();

}
  
function lerpAlpha () {
  
    //alpha=1;
    //var lerp : float = Mathf.PingPong (Time.time, duration) / duration; //This can be used to bounce between opacities
    var lerp : float = Time.time/duration; //This can be used to have a predetermined 'fade' time
  
    alpha = Mathf.Lerp(1.0, 0.5, lerp) ;
    GetComponent.<Renderer>().material.color.a = alpha;
}

function reseter()
{
    GetComponent.<Renderer>().material.color.a = 1;
}

