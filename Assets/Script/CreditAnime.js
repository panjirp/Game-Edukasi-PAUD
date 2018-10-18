var speed = 148;
var crawling = false;


function Start()
{
    // init text here, more space to work than in the Inspector (but you could do that instead)
    var tc = GetComponent(GUIText);
     }

function Update ()
{
    if (!crawling)
        return;
    transform.Translate(Vector3.up * Time.deltaTime * speed);
    if (gameObject.transform.position.y > 2200)
    {
        crawling = false;
        Application.LoadLevel("Menu");
    }
}