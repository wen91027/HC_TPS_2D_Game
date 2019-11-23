using UnityEngine;

public class Bird : MonoBehaviour
{
    [Header("跳躍高度"), Range(10, 2000)]
    public int jump = 100;
    [Header("是否死亡"), Tooltip("用來判斷角色是否死亡，true 死亡，false 還沒死亡")]
    public bool dead;
    [Header("剛體")]
    public Rigidbody2D BirdRig;

    /// <summary>
    /// 小雞跳躍方法。
    /// </summary>
    private void Jump()
    {
        //判斷按左鍵
        //Mouse0:左鍵  Mouse1:右鍵  Mouse2:滾輪 
        //適用手機觸控
        if (Input.GetKeyDown(KeyCode.Mouse0)) 
        {
            print("按左鍵");
            //BirdRig.velocity = new Vector2(0, 0);
            BirdRig.Sleep(); //剛體.睡()  -剛體資訊重設
            BirdRig.gravityScale = 1;  //雞重力變1
            //跳
            BirdRig.AddForce(new Vector2(0, jump)); //剛體.加推力(二維向量(左右,上下))
        }
        //跳
    }

    /// <summary>
    /// 小雞死亡方法。
    /// </summary>
    private void Dead()
    {

    }
    private void Update()
    {
        Jump();
    }

}
