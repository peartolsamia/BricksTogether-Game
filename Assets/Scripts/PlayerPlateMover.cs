using UnityEngine;
using UnityEngine.Device;

public class PlayerPlateMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;


    [SerializeField] private TouchActionReader touchReader;
    [SerializeField] private Camera cam;




    void Start()
    {
        if (cam == null) cam = Camera.main;
    }



    void Update()
    {
        if (touchReader == null || cam == null) return;



        float touchX = touchReader.CurrentX;
        //Debug.Log($"Touch X position: {touchX}");




        
        float z = Mathf.Abs(cam.transform.position.z - transform.position.z);

        Vector3 world = cam.ScreenToWorldPoint(
            new Vector3(touchX, UnityEngine.Screen.height * 0.5f, z)
        );

        
        

        // Soft Follow
        Vector3 target = new Vector3(world.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * moveSpeed);

    }


}
