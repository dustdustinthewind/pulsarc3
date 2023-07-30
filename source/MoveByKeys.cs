// MoveByKeys
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class MoveByKeys : Photon.MonoBehaviour
{
	public float Speed = 10f;

	public float JumpForce = 200f;

	public float JumpTimeout = 0.5f;

	private bool FPDMMJNCMED;

	private float KNCGPFGKKAB;

	private Rigidbody AELEPMINKFF;

	private Rigidbody2D NHHFOFMNODM;

	public void NBGIMIDICKE()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void EMKDDJHINBH()
	{
		if (!IJBFILBDGDO().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("Sets the boolean value of the Auto Focus Input Field property.") < 277f || Input.GetAxisRaw("_MainTex2") > 1292f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("X");
		}
		if (KNCGPFGKKAB <= 1318f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-68)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("SettingsCanvas") < 1824f || Input.GetAxisRaw("{0} hours ago") > 1369f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Intensity");
		}
	}

	public void DNNFHBOOPIN()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void Start()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void JNHMLJGFKDA()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("SetTrailZoomSpeed") < 1016f || Input.GetAxisRaw("player.orangearc") > 1402f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("\\\"");
		}
		if (KNCGPFGKKAB <= 752f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.A))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("\t") < 789f || Input.GetAxisRaw("21x3") > 1667f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Far");
		}
	}

	public void PAKPHKPDKGE()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FAINCOEAEAG()
	{
		if (!PHCBHAFMDEJ().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_MainTex2") < 1588f || Input.GetAxisRaw("_Heigh") > 1249f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_ScreenResolution");
		}
		if (KNCGPFGKKAB <= 659f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-90)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_MatrixColor") < 121f || Input.GetAxisRaw("colorB") > 1506f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack_RainFX_Anm2");
		}
	}

	public void CCMPJCKFHIN()
	{
		if (!OELHGNKAMEG().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("BitsData") < 1496f || Input.GetAxisRaw("CameraFilterPack_Glasses_On6") > 1176f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("#rate!");
		}
		if (KNCGPFGKKAB <= 1743f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-15)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Offsets") < 1539f || Input.GetAxisRaw("Item invalid. Make sure your mod contains at leats one file.") > 1154f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Color_YUV");
		}
	}

	public void MAPJKNBGKFG()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("NO") < 42f || Input.GetAxisRaw("[UI] ") > 479f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_SunThreshold");
		}
		if (KNCGPFGKKAB <= 950f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-59)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw(": ") < 75f || Input.GetAxisRaw("Protocol switch from: ") > 9f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Alpha2");
		}
	}

	public void JKFDDNMPOJH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void HBLIJHPIGBF()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("mapselector.lastSearch") < 1052f || Input.GetAxisRaw("SettingsCanvas") > 867f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(" to ");
		}
		if (KNCGPFGKKAB <= 766f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-52)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Value4") < 364f || Input.GetAxisRaw("<command>") > 1057f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("settings.arcshitsoundtimedelay");
		}
	}

	public void NLNMGNBNNAO()
	{
		if (!BLMHOKPIMOD().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("ItemsCountText") < 1122f || Input.GetAxisRaw("Loaded Game: ") > 97f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
		}
		if (KNCGPFGKKAB <= 715f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-41)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.") < 463f || Input.GetAxisRaw("Clears the console and prints the logs in the specified range") > 169f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Tab2Content");
		}
	}

	public void IMIFACIMICO()
	{
		if (!JAEJDHHCJJO().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("float,0") < 1787f || Input.GetAxisRaw("settings.showHP") > 467f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Set Particles Color");
		}
		if (KNCGPFGKKAB <= 1956f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-95)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw(" does not exist!") < 138f || Input.GetAxisRaw("Cannot send messages when not connected. Either connect to Photon OR use offline mode!") > 651f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("EventMenu");
		}
	}

	public void POKHKAIPAJE()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("maps.") < 236f || Input.GetAxisRaw("/?player=") > 1612f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Blend2Camera_Saturation");
		}
		if (KNCGPFGKKAB <= 41f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Pipe))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Set Satellite Trail Width") < 67f || Input.GetAxisRaw("Done! You are a contributor until: ") > 219f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("settings.enablehitsoundsinrelax");
		}
	}

	public void FixedUpdate()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("Horizontal") < -0.1f || Input.GetAxisRaw("Horizontal") > 0.1f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Horizontal");
		}
		if (KNCGPFGKKAB <= 0f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Space))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Vertical") < -0.1f || Input.GetAxisRaw("Vertical") > 0.1f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Vertical");
		}
	}

	public void NPLCENPNJBM()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void GGLOGIGAJCA()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("StopSounds") < 1376f || Input.GetAxisRaw("y") > 819f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results");
		}
		if (KNCGPFGKKAB <= 1976f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-118)))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("SetSpeed") < 207f || Input.GetAxisRaw(" not exist") > 235f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("y");
		}
	}

	public void IOAHLGNENLH()
	{
		if (!ACPGHFHDCIP().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_FadeFX") < 1668f || Input.GetAxisRaw("_TimeX") > 200f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("settings.enableranking");
		}
		if (KNCGPFGKKAB <= 641f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.G))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Joystick1Button8") < 1336f || Input.GetAxisRaw("To {0} at Index {1} \n") > 421f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Value");
		}
	}

	public void AONLFBOLNIJ()
	{
		if (!GBMJAPGLMGB().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_Value") < 1216f || Input.GetAxisRaw("No valid adaptive tonemapper type found!") > 1712f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Source: ");
		}
		if (KNCGPFGKKAB <= 1303f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.K))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("[MapEditor] Item creation successful! Published Item ID: ") < 1158f || Input.GetAxisRaw("_VelocityScale") > 1343f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("speed");
		}
	}

	public void LMCGIOCFGMH()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("BadgeImage") < 452f || Input.GetAxisRaw("Left") > 1634f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("menu.selectedplaymode");
		}
		if (KNCGPFGKKAB <= 706f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.RightParen))
			{
				KNCGPFGKKAB = JumpTimeout;
				Vector2 vector = Vector2.up * JumpForce;
				if (NHHFOFMNODM != null)
				{
					NHHFOFMNODM.AddForce(vector);
				}
				else if (AELEPMINKFF != null)
				{
					AELEPMINKFF.AddForce(vector);
				}
			}
		}
		else
		{
			KNCGPFGKKAB -= Time.deltaTime;
		}
		if (!FPDMMJNCMED && (Input.GetAxisRaw("InventoryGrid") < 474f || Input.GetAxisRaw("_Value2") > 1414f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_ZCurve");
		}
	}

	public void BGDPIHMAACO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void KIMMMCJFMAB()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}
}
