using UnityEngine;

public class movingscript : MonoBehaviour
{
    public float speedacelerator = 1;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x - speedacelerator, this.transform.position.y, this.transform.position.z);
    }
}