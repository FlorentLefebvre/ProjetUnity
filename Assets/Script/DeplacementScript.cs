using UnityEngine;
using System.Collections;

public class DeplacementScript : MonoBehaviour {
	
	[SerializeField]
	private Transform _player;

	public Transform Player {
		get {
			return this._player;
		}
		set {
			_player = value;
		}
	}
	
	[SerializeField]
	private float _speed = 1f;

	public float Speed {
		get {
			return this._speed;
		}
		set {
			_speed = value;
		}
	}
	
	[SerializeField]
	private bool _isJumping = false;

	public bool IsJumping {
		get {
			return this._isJumping;
		}
		set {
			_isJumping = value;
		}
	}
	
	[SerializeField]
	private int _frame = 0;

	public int Frame {
		get {
			return this._frame;
		}
		set {
			_frame = value;
		}
	}	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Z))
		{
			Player.Translate(Vector3.forward * Speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.Q))
		{
			Player.Translate(Vector3.left * Speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.S))
		{
			Player.Translate(Vector3.back * Speed * Time.deltaTime);
		}
		if(Input.GetKey(KeyCode.D))
		{
			Player.Translate(Vector3.right * Speed * Time.deltaTime);
		}
		if(Input.GetKeyDown(KeyCode.Space)&&IsJumping==false)
		{
			IsJumping = true;
			Frame = 0;
			rigidbody.useGravity=false;
		}
		if(IsJumping)
		{
			if(Frame >=0 && Frame <10)
			{
				Player.Translate(Vector3.up * 5f * Time.deltaTime);
				Frame++;
			}
			if(Frame >=10 && Frame <30)
			{
				Player.Translate(Vector3.up * 1f * Time.deltaTime);
				Frame++;
			}
			if(Frame==30)
			{
				rigidbody.useGravity=true;
				IsJumping=false;
				
			}
		}
	}
	
	void OnCollisionEnter() {
		rigidbody.useGravity=true;
	}
}
