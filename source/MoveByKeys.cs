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

	public void ODBNMPGBCGO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void ANCKKLFPGDI()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void NNCCPEBIAKH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void CIPKEPDELJB()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void LBBBICDEPHA()
	{
		if (!ACPGHFHDCIP().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value4") < 147f || Input.GetAxisRaw("shader.frost") > 1187f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("useSrcAlphaAsMask");
		}
		if (KNCGPFGKKAB <= 1453f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Greater))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("  |  ") < 1144f || Input.GetAxisRaw("DifficultyBG") > 529f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("float,0.5");
		}
	}

	public void DBLILJGKGHJ()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void JKFDDNMPOJH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void MFGNBDFHAHK()
	{
		if (!GMAHNPNHMFK().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("OK") < 1905f || Input.GetAxisRaw("Beat Detected") > 156f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("RoomDescriptionText");
		}
		if (KNCGPFGKKAB <= 268f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Semicolon))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("inventory.selected.") < 978f || Input.GetAxisRaw("Vertical") > 484f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_DistortionSize");
		}
	}

	public void NLPKBAECHMO()
	{
		if (!GMAHNPNHMFK().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("r") < 1780f || Input.GetAxisRaw("0x") > 190f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("stretchWidth");
		}
		if (KNCGPFGKKAB <= 95f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Quote))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw(".png") < 735f || Input.GetAxisRaw("settings.shaders.bloomintencity") > 505f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("\t");
		}
	}

	public void ILCFPCIPENO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void NBGIMIDICKE()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void DBEMDAJDDDA()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FEONBLOKEBF()
	{
		if (!CIACEFBNDDJ().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("\" for viewID ") < 117f || Input.GetAxisRaw("menu.selectedplaymode") > 1585f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("#ok");
		}
		if (KNCGPFGKKAB <= 1629f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.M))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("#91CCFF") < 1091f || Input.GetAxisRaw("_Value3") > 1928f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Jazz");
		}
	}

	public void LIBGAKMKHJJ()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void GLFLNGNKCDN()
	{
		if (!JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.") < 904f || Input.GetAxisRaw("_Value") > 1483f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("0,1,false");
		}
		if (KNCGPFGKKAB <= 1727f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)21))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Value") < 1031f || Input.GetAxisRaw("Object ID. Case-Sensitive") > 724f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("SpectatingUserInfo");
		}
	}

	public void NCNPAKFAFOE()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void HDMDKOKOOJC()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void JBPFBKMLGAD()
	{
		if (!FFIPLLNKGEN().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1736f || Input.GetAxisRaw(") but there is no recycle bin setup for it. Falling back to Instantiate") > 599f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.");
		}
		if (KNCGPFGKKAB <= 1215f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)10))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("EnableRankedNotificationsToggle") < 1258f || Input.GetAxisRaw("_PositionY") > 1748f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw(" not exist");
		}
	}

	public void DFCAEFFNGEH()
	{
		if (!OELHGNKAMEG().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value3") < 1087f || Input.GetAxisRaw("_ScreenResolution") > 458f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("ConnectToMaster() disabled the offline mode. No longer offline.");
		}
		if (KNCGPFGKKAB <= 1799f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-28)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Glasses_On") < 1822f || Input.GetAxisRaw("_NoiseTex") > 206f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_PositionX");
		}
	}

	public void LFLAGHIJCCN()
	{
		if (!EDIJKHEMPAD().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("music") < 1268f || Input.GetAxisRaw("_MaxSteps") > 552f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("[MapEditor] Loaded music file: ");
		}
		if (KNCGPFGKKAB <= 1312f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)10))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("settings.crosshairopacity") < 1773f || Input.GetAxisRaw("settings.shaders") > 777f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	public void JOHEGKAGALG()
	{
		if (!AAMNKPHHHCI().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1432f || Input.GetAxisRaw("_TimeX") > 1361f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])");
		}
		if (KNCGPFGKKAB <= 1546f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-53)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("itemid") < 395f || Input.GetAxisRaw("_Value2") > 479f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	public void DKGBFNCOAEO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FACPCHPGPGN()
	{
		if (!base.photonView.isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("_Value") < 481f || Input.GetAxisRaw(" Remote called.") > 1212f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(".lastCheckpoint.lives");
		}
		if (KNCGPFGKKAB <= 1646f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-30)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("OK") < 304f || Input.GetAxisRaw("_Near") > 695f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("sfxVolume");
		}
	}

	public void EMKDDJHINBH()
	{
		if (!OELHGNKAMEG().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("</color>") < 950f || Input.GetAxisRaw("Set Trail Zoom (player camera move forward effect). Base value - 1.5") > 1316f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_EmissionColor");
		}
		if (KNCGPFGKKAB <= 1030f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)72))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Internal LUT") < 61f || Input.GetAxisRaw("). ") > 1476f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Value3");
		}
	}

	public void MGMAOBPPOBJ()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void KCCIEMBMOBA()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void EKGDBEJAGPM()
	{
		if (!EOOCGIFFKBG().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("Fake") < 1001f || Input.GetAxisRaw("SetSunMinSize") > 1514f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_ScreenResolution");
		}
		if (KNCGPFGKKAB <= 1798f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)3))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw(" while connecting to: ") < 295f || Input.GetAxisRaw("ERROR: Preview file must be <1MB!") > 1229f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Distortion");
		}
	}

	public void MIGFKFBOBDK()
	{
		if (!ACPGHFHDCIP().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw(".completed") < 487f || Input.GetAxisRaw("BadgeImage") > 1857f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Color_Convert_Normal");
		}
		if (KNCGPFGKKAB <= 1877f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-96)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Distortion") < 82f || Input.GetAxisRaw("Default UI Material") > 422f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("JoinButton");
		}
	}

	public void OPAMLNBLCHJ()
	{
		if (!GMAHNPNHMFK().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("Set satellite trail width") < 1740f || Input.GetAxisRaw("_TimeX") > 1765f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("Submit");
		}
		if (KNCGPFGKKAB <= 730f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-91)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Glitch_Mozaic") < 1949f || Input.GetAxisRaw("CompletedLevel") > 1906f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/TV_Artefact");
		}
	}

	public void PKLOBJHKFEO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void EKENDPKLMFN()
	{
		if (!JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_DistortionLevel") < 1275f || Input.GetAxisRaw(".ogg") > 1235f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("StopSounds");
		}
		if (KNCGPFGKKAB <= 745f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)87))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Clear Environment") < 1400f || Input.GetAxisRaw("/icon") > 1341f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("\n");
		}
	}

	public void FHGKIOOMMOH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void PMPKMGKAAJH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FIKFJDFELIP()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void GGLOGIGAJCA()
	{
		if (!IBKCMBIGOEJ().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("maps.") < 1139f || Input.GetAxisRaw("Hidden/LensAberrations") > 555f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(". Prefab must have a PhotonView component.");
		}
		if (KNCGPFGKKAB <= 1096f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)5))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Value4") < 1707f || Input.GetAxisRaw("_Value") > 421f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Colorisation");
		}
	}

	public void Start()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void OBPFNGKAOLD()
	{
		if (!FFIPLLNKGEN().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("/") < 940f || Input.GetAxisRaw("Missing shader in ") > 592f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/FX_Plasma");
		}
		if (KNCGPFGKKAB <= 304f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-74)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Received your NickName from server. Updating local value to: {0}") < 26f || Input.GetAxisRaw("_Fade") > 1219f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Data/Skins/");
		}
	}

	public void NNHFKFEMONK()
	{
		if (!CIACEFBNDDJ().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("CameraFilterPack_eyes_vision_2") < 1205f || Input.GetAxisRaw(" from: ") > 476f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_MainTex2");
		}
		if (KNCGPFGKKAB <= 270f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-48)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("MAPS NOT FOUND") < 240f || Input.GetAxisRaw("OnClick") > 372f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_UserLutTex");
		}
	}

	public void CCMPJCKFHIN()
	{
		if (!BLMHOKPIMOD().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value2") < 1685f || Input.GetAxisRaw("CameraFilterPack/Film_Grain") > 1886f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(":");
		}
		if (KNCGPFGKKAB <= 543f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Semicolon))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("s") < 839f || Input.GetAxisRaw("CameraFilterPack/Blend2Camera_HardLight") > 1872f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("\nv.");
		}
	}

	public void IDJKNBDKHBD()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void PDHKMDBNGGN()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FNCDAPDOBBI()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void PAKPHKPDKGE()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void KNBJBNDGCIJ()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void EFJDNLGNACH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void ENDMKGLNGPG()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_MainTex2") < 1199f || Input.GetAxisRaw("RPC can't be sent to target PhotonPlayer being null! Did not send \"") > 744f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("RequestForPickupItems");
		}
		if (KNCGPFGKKAB <= 1431f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Comma))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("y") < 1283f || Input.GetAxisRaw("_Value1") > 1065f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("OxOD.lastPath");
		}
	}

	public void BGDPIHMAACO()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void MAPJKNBGKFG()
	{
		if (!OELHGNKAMEG().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_ScreenResolution") < 1799f || Input.GetAxisRaw("shader.sunny") > 1412f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("settings_bindings_controller_type");
		}
		if (KNCGPFGKKAB <= 1442f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Tab))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("[PlayerController] ") < 1969f || Input.GetAxisRaw("skin.") > 1421f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("0");
		}
	}

	public void DAHFFNNIGML()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void LMCGIOCFGMH()
	{
		if (!AAMNKPHHHCI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("_Value") < 727f || Input.GetAxisRaw("Object ID. Case-Sensitive") > 1717f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("[PlayerController] ");
		}
		if (KNCGPFGKKAB <= 1695f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-100)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw(".") < 637f || Input.GetAxisRaw("_ScreenResolution") > 232f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Horizontal");
		}
	}

	public void HEPPILHCKJC()
	{
		if (!JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("Mouse") < 223f || Input.GetAxisRaw("Result for ") > 1347f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_ScreenResolution");
		}
		if (KNCGPFGKKAB <= 1583f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.I))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("[EditorEvent] Exception: ") < 1463f || Input.GetAxisRaw("Exit to menu?") > 1482f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Visualize");
		}
	}

	public void IFMMDLHMDOB()
	{
		if (!GBMJAPGLMGB().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("[EMPTY]") < 1885f || Input.GetAxisRaw("???") > 51f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(",");
		}
		if (KNCGPFGKKAB <= 1374f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Y))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}") < 1864f || Input.GetAxisRaw("settings.hitvariation") > 1923f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		}
	}

	public void GCJNCABKDHI()
	{
		if (!IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("ResetSpeed") < 1104f || Input.GetAxisRaw("menu.enableselectormusic") > 1091f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw(",");
		}
		if (KNCGPFGKKAB <= 946f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-6)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_ScreenResolution") < 115f || Input.GetAxisRaw("float,2") > 991f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Value5");
		}
	}

	public void PMBBMCDEHBG()
	{
		if (!EDIJKHEMPAD().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("_BlurRadius") < 1169f || Input.GetAxisRaw("_Value2") > 666f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Blend2Camera_LinearBurn");
		}
		if (KNCGPFGKKAB <= 1123f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Z))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("\" on viewID ") < 1620f || Input.GetAxisRaw("_ScreenResolution") > 1445f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("mapselector.orderby");
		}
	}

	public void DLBODOFAJGM()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void MFMILEABJBO()
	{
		if (!EOOCGIFFKBG().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("SetSatelliteRadius") < 70f || Input.GetAxisRaw(".g") > 1625f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("HandsCountSlider");
		}
		if (KNCGPFGKKAB <= 1957f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Ampersand))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("ControllerLeftY") < 1502f || Input.GetAxisRaw("#activechallenges") > 1864f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Edge_Edge_filter");
		}
	}

	public void BEBNOKFLJPH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void DIPDEHOOBPG()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void MJEFMIPLFAB()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void APMCMFKPPNE()
	{
		if (!ACPGHFHDCIP().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw("_Linecount") < 1909f || Input.GetAxisRaw("grid") > 1315f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_AdaptationMax");
		}
		if (KNCGPFGKKAB <= 203f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)14))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("#done") < 1488f || Input.GetAxisRaw("0.00") > 1631f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Blue_R");
		}
	}

	public void MMOKKAPFGAK()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FLKEJJEGCFA()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void KOJKBFDNGDK()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
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

	public void JHANGPCOCIG()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void HGNJDPGPCEL()
	{
		if (!GBHNDHLAJLI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("Connection error: ") < 905f || Input.GetAxisRaw("_Linecount") > 1458f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("time");
		}
		if (KNCGPFGKKAB <= 710f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.DoubleQuote))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("CameraFilterPack/Atmosphere_Rain") < 449f || Input.GetAxisRaw("Please attach component to a Graphical UI component") > 884f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Distortion");
		}
	}

	public void LGOHDOFFKIB()
	{
		if (!OELHGNKAMEG().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw("0") < 1616f || Input.GetAxisRaw("Bad parameters for delete! Use <key>") > 374f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("UsernameText");
		}
		if (KNCGPFGKKAB <= 562f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)84))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("_Intensity") < 520f || Input.GetAxisRaw("CameraFilterPack/Blend2Camera_LinearLight") > 1717f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Bad parameters for getbool! Use <key> <value>");
		}
	}

	public void ADIHLKFGDPL()
	{
		if (!AAMNKPHHHCI().DOLKFPIABDD())
		{
			return;
		}
		if (Input.GetAxisRaw(".sav") < 1917f || Input.GetAxisRaw("Up") > 1420f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Film_Grain");
		}
		if (KNCGPFGKKAB <= 1690f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Q))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("ViewMenu") < 1642f || Input.GetAxisRaw("Crosshair2") > 592f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Can't execute Disconnect() while not connected. Nothing changed. State: {0}");
		}
	}

	public void HBLIJHPIGBF()
	{
		if (!IBKCMBIGOEJ().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("ResetButton") < 1812f || Input.GetAxisRaw("MapEnd") > 1116f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("_Far");
		}
		if (KNCGPFGKKAB <= 519f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-34)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw(" has no method \"") < 570f || Input.GetAxisRaw("L1") > 1512f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("/icon");
		}
	}

	public void COIJKMKIEAK()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void OKFECANLIHE()
	{
		if (!EDIJKHEMPAD().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("SetTrailZoomSpeed") < 1015f || Input.GetAxisRaw("#,0") > 786f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("RoomPlayersCountText");
		}
		if (KNCGPFGKKAB <= 598f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey(KeyCode.Exclaim))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("EventData0DropDownList") < 513f || Input.GetAxisRaw("_MatrixColor") > 199f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("LevelProgressBar");
		}
	}

	public void ECKBEJEAKEE()
	{
		if (!GBMJAPGLMGB().isMine)
		{
			return;
		}
		if (Input.GetAxisRaw("FrostCanvas") < 1310f || Input.GetAxisRaw("_ScreenSize") > 1291f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("???");
		}
		if (KNCGPFGKKAB <= 801f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)(-64)))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("LogStats") < 1713f || Input.GetAxisRaw("Right Stick Click") > 222f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("Joystick1Button8");
		}
	}

	public void KMCPMOGKDEH()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void NNFMIAFHMJM()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void HKKIBBNMNDD()
	{
		if (!FFIPLLNKGEN().BGJKMGJBPFA())
		{
			return;
		}
		if (Input.GetAxisRaw("ArcsNoHitsoundTimeDelaySlider") < 643f || Input.GetAxisRaw("The given 2D texture ") > 1023f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("EventData0DropDownList");
		}
		if (KNCGPFGKKAB <= 227f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)14))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("#close") < 44f || Input.GetAxisRaw("EditMenu") > 1351f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("DPADHOR");
		}
	}

	public void HMPGIFBJFIK()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void GPNAOAKCMHC()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void FNALDLBGCJA()
	{
		if (!JAEJDHHCJJO().KCAOJFPDEIP())
		{
			return;
		}
		if (Input.GetAxisRaw(" has been disabled as it's not supported on the current platform.") < 789f || Input.GetAxisRaw("2hands") > 399f)
		{
			base.transform.position += Vector3.right * (Speed * Time.deltaTime) * Input.GetAxisRaw("CameraFilterPack/Edge_Sobel");
		}
		if (KNCGPFGKKAB <= 751f)
		{
			if ((AELEPMINKFF != null || NHHFOFMNODM != null) && Input.GetKey((KeyCode)71))
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
		if (!FPDMMJNCMED && (Input.GetAxisRaw("Copy from ") < 506f || Input.GetAxisRaw("_ScreenResolution") > 1109f))
		{
			base.transform.position += Vector3.forward * (Speed * Time.deltaTime) * Input.GetAxisRaw("_TimeX");
		}
	}

	public void KIMMMCJFMAB()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void IMCKJCHKMKB()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}

	public void JOPCCCCHNLI()
	{
		FPDMMJNCMED = GetComponent<SpriteRenderer>() != null;
		NHHFOFMNODM = GetComponent<Rigidbody2D>();
		AELEPMINKFF = GetComponent<Rigidbody>();
	}
}
