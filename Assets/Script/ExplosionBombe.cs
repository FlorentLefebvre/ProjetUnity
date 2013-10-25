using UnityEngine;
using System.Collections;

public class ExplosionBombe : MonoBehaviour {
	
	[SerializeField]
	private float _countDown = 3;

	public float CountDown {
		get {
			return this._countDown;
		}
		set {
			_countDown = value;
		}
	}
	
	[SerializeField]
	private Transform _location;

	public Transform Location {
		get {
			return this._location;
		}
		set {
			_location = value;
		}
	}
	
		[SerializeField]
	private bool _boom = false;

	public bool Boom {
		get {
			return this._boom;
		}
		set {
			_boom = value;
		}
	}
	
	private float _startCountDown;
	
	private bool _exploded = false;

	public bool Exploded {
		get {
			return this._exploded;
		}
		set {
			_exploded = value;
		}
	}	
	// Use this for initialization
	void Start () {
		_startCountDown = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate () {
		if( _exploded == false)
		{
			if ( Time.time - _startCountDown > _countDown)
			{
				_boom = true;
			}
		}
	}
}
