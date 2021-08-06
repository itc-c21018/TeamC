using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapiokaController : MonoBehaviour
{
    const int MinLane = -4;
    const int MaxLane = 4;
    const float LaneWidth = 1.0f;
    const int DefaultLife = 3;
    const float StunDuration = 0.5f;

    CharacterController controller;
    //Animator animator;

    public Vector3 moveDirection = Vector3.zero;
    public int scoreindex = 0;
    int targetLine;
    int life = DefaultLife;
    float recoverTime = 0.0f;

    public float gravity;
    public float speedindexZ;
    public float speedX;
    public float speedJump;
    public float accelerationZ;
    public int scoreD;
    
    public int Life()
    {
        return life;
    }

    bool IsStun()
    {
        return recoverTime > 0.0f || life <= 0;
    }

    GameObject stageGenerator;

    StageGenerator script;

    // Start is called before the first frame update
    void Start()
    {
        stageGenerator = GameObject.Find("StageGenerator");
        script = stageGenerator.GetComponent<StageGenerator>();

        //
        controller = GetComponent<CharacterController>();
        //animator = GetComponent<Animator>();
        //Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //speedZ‚ÍspeedindexZ(“ü—Í)‚Ì’l‚Æspeedlevel‚Ì’l‚ð‘«‚µ‚½‚à‚Ì
        float speedZ = speedindexZ + script.speedlevel;

        //int charaPositionIndex = (int)(script.character.position.z / script.StageChipSize);
        //
        if (Input.GetKeyDown("left")) MoveToLeft();
        if (Input.GetKeyDown("right")) MoveToRight();
        if (Input.GetKeyDown("space")) Jump();

        if (IsStun())
        {
            //
            moveDirection.x = 0.0f;
            moveDirection.z = 0.0f;
            recoverTime -= Time.deltaTime;
        }
        else
        {
            //
            float acceleratedZ = moveDirection.z + (accelerationZ * Time.deltaTime);
            moveDirection.z = Mathf.Clamp(acceleratedZ, 0, speedZ);

            //
            float ratioX = (targetLine * LaneWidth - transform.position.x) / LaneWidth;
            moveDirection.x = ratioX * speedX;
        }
        /*if (controller.isGrounded)
        {
            if(Input.GetAxis("Vertical") > 0.0f)
            {
                moveDirection.z = Input.GetAxis("Vertical") * speedZ;
            }
            else
            {
                moveDirection.z = 0;
            }

            transform.Rotate(0, Input.GetAxis("Horizontal") * 3, 0);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = speedJump;
                animator.SetTrigger("Jump");
            }
        }*/

        //
        moveDirection.y -= (gravity + script.gravitylevel) * Time.deltaTime;
        //counter += Time.deltaTime

        //
        Vector3 globalDirection = transform.TransformDirection(moveDirection);
        controller.Move(globalDirection * Time.deltaTime);

        //
        if (controller.isGrounded) moveDirection.y = 0;

        //
        //animator.SetBool("run", moveDirection.z > 0.0f);

        /*if (charaPositionIndex / script.levelUpIndex >= script.level)
        {
            speedZ++;
        }*/
    }

    //
    public void MoveToLeft()
    {
        if (IsStun()) return;
            if (controller.isGrounded && targetLine > MinLane) targetLine -= 2;
    }

    //
    public void MoveToRight()
    {
        if (IsStun()) return;
        if (controller.isGrounded && targetLine < MaxLane) targetLine += 2;
    }

    //
    public void Jump()
    {
        if (IsStun()) return;
        if (controller.isGrounded)
        {
            moveDirection.y = speedJump;

            //
            //animator.SetTrigger("Jump");
        }
    }

    //
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (IsStun()) return;

        if(hit.gameObject.tag == "Enemy")
        {
            //
            life--;
            //scoreindex = scoreindex + scoreD;
            recoverTime = StunDuration;

            //
            //animator.SetTrigger("damage");

            //
            Destroy(hit.gameObject);
        }

        if (hit.gameObject.tag == "Enemy2")
        {
            //
            scoreindex = scoreindex + scoreD;
            recoverTime = StunDuration;

            //
            //animator.SetTrigger("damage");

            //
            Destroy(hit.gameObject);
        }
    }
}
