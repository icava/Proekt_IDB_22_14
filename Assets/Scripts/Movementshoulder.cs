using UnityEngine;

public class MovementShoulder : MonoBehaviour
{
    public int switch_on;
    public GameObject Movement1;
    public GameObject Movement2;
    public GameObject gameObject4;
    // Start is called before the first frame update
    void Start()
    {
        switch_on = 0;
    }
    // Update is called once per frame
     async void Update()
     {
        switch (switch_on)
        {
            case 0:
                {
                    gameObject4.transform.position += new Vector3(0, 0, 0.01f);
                    if(gameObject4.transform.position.z > 8.7){
                        switch_on = 1;
                    }
                    break;
                }
            case 1:
                {
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(0, -64.535f, -89.718f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(25.349f, 0, 0), Time.deltaTime); transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 105), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 105))
                    {
                        switch_on = 2;

                    }
                    break;
                }
            case 2:
                {
                    Movement1.transform.localRotation = Quaternion.Lerp(Movement1.transform.localRotation, Quaternion.Euler(-0.203f, 30.438f, -90.922f), Time.deltaTime);
                    Movement2.transform.localRotation = Quaternion.Lerp(Movement2.transform.localRotation, Quaternion.Euler(131.645f, 0, 0), Time.deltaTime);
                    transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(0, 0, 60), Time.deltaTime);
                    if (transform.localRotation == Quaternion.Euler(0, 0, 60))
                    {

                        switch_on = 1;

                    }
                    break;
                }
        }
       
    }

}
