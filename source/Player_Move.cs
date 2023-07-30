// Player_Move
using UnityEngine;

[AddComponentMenu("Hard Shell Studios/Examples/Player Move")]
public class Player_Move : MonoBehaviour
{
	public bool canMove;

	public float moveSpeed;

	public float sprintMultiplier;

	public float jumpForce;

	private float LODOOHOEFND = 0.5f;

	private Rigidbody PGONDACAPAA;

	private void DKOPKPBLDHH()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool AJFHNOAOPPO()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1122f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 824f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1999f);
	}

	private void HMNLHMLILKD()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.POLDEEDNMBE("_ColorBuffer", "OK", 1783f) + hardInput.PPKDBNLBDIJ("GlassAberration", 277f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE(" to: ", "_TimeX", 831f) + hardInput.EBBBDEAMIKO("CameraFilterPack/Blend2Camera_Multiply", 1763f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK("id") && EFDPCMNBJOP())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool PGNLEPOGBJE()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1793f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 584f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1111f);
	}

	private void MAOCOEGAFND()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Player Disconnected", "ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", 1254f) + hardInput.PPKDBNLBDIJ("menu.tabid", 489f)) * num, PGONDACAPAA.velocity.y, (hardInput.ELDCBALLLJI("_Offsets", "#no", 1751f) + hardInput.PKIDLNBMMBO("_Value", 1275f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("#yes") && AJFHNOAOPPO())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool MJNOLBIOBEE()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 464f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1903f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 16f);
	}

	private void AEEGKLABFLN()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("_TimeX", "_Offsets", 1126f) + hardInput.DCOBLPDBKID("[MapEditor] Loaded music file: ", 1846f)) * num, PGONDACAPAA.velocity.y, (hardInput.ELDCBALLLJI("_Value4", "Ev DestroyAll! By PlayerId: ", 560f) + hardInput.DCOBLPDBKID("_TimeX", 1634f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("_Fade") && PCKCJNKFAPF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void DLBODOFAJGM()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool KBHPPEAGMJB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 750f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 567f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 839f);
	}

	private bool MLEODNOPGMI()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1647f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1117f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1388f);
	}

	private void NPLCENPNJBM()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool NAEONENECEC()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 0.5f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 0.1f);
	}

	private bool JPMFJAMBAPA()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 149f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1952f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 935f);
	}

	private void Start()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("Right", "Left", 7f) + hardInput.GetAxis("ControllerLeftX", 7f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("Forward", "Backward", 7f) + hardInput.GetAxis("ControllerLeftY", 7f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Jump") && NAEONENECEC())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void IDIIELPAMCJ()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.POLDEEDNMBE("#rt", "shader.sunny", 1041f) + hardInput.DCOBLPDBKID("settings.fps", 1380f)) * num, PGONDACAPAA.velocity.y, (hardInput.ELDCBALLLJI("No info", ".lastCheckpoint.playerdistance", 1739f) + hardInput.PPKDBNLBDIJ("RoomDescriptionText", 1392f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK("_ScreenResolution") && PCKCJNKFAPF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void AAPKBNDHBLI()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.EAFHOGEHLDJ("MapEnd", "EXCEPTION:", 823f) + hardInput.GMKFPOJIHOH(".highscore", 1731f)) * num, PGONDACAPAA.velocity.y, (hardInput.EAFHOGEHLDJ("UseScanLineSize", "The shader ", 345f) + hardInput.GetAxis("_FixDistance", 771f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("[MapsData] Key ") && EFDPCMNBJOP())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void IIFCIDDJHPM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.POLDEEDNMBE("ShineEffect", "Vertical", 1106f) + hardInput.GetAxis("_ScreenResolution", 1963f)) * num, PGONDACAPAA.velocity.y, (hardInput.EAFHOGEHLDJ("%", " Also make sure to disable sprite packing for this sprite.", 688f) + hardInput.GMKFPOJIHOH("AddEnvironmentSprite", 1934f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("Player Disconnected") && FBMAFPFLLMB())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void BGDONBMDPGM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.EAFHOGEHLDJ("menu.enableselectormusic", "default", 562f) + hardInput.PKIDLNBMMBO("_Value2", 1497f)) * num, PGONDACAPAA.velocity.y, (hardInput.ELDCBALLLJI("#8E8E8EFF", "achievements.21.completed.", 803f) + hardInput.EBBBDEAMIKO("_Value", 247f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("FinalScoreSmallText") && CHCNPGIKMCK())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool LCIAHJDFIKH()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 755f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 856f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 888f);
	}

	private void NDAJBJFJGCF()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.BMDFLMLNPHN("Preparing configuration...", "RestartButton", 528f) + hardInput.GMKFPOJIHOH("_ScreenResolution", 1614f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("ItemNameText", "DISTORT", 722f) + hardInput.NPAAKMHOGBO("_ScreenResolution", 1333f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK(".lastCheckpoint.powerupsScore") && PGNLEPOGBJE())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool CHCNPGIKMCK()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1542f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 650f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 33f);
	}

	private bool MJDJIOOKKLP()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 254f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 745f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1862f);
	}

	private void KLILJHJNICK()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool DPMGOMNCBCE()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1785f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 786f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1224f);
	}

	private void OEENOOGEEHD()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.ELDCBALLLJI("VisionBlur", ":", 1971f) + hardInput.NPAAKMHOGBO("_Threshold", 909f)) * num, PGONDACAPAA.velocity.y, (hardInput.EAFHOGEHLDJ("id", "[PlayerBase] Ready", 1544f) + hardInput.PKIDLNBMMBO("tip", 948f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("_ColorB") && JKMFLNFDNEF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool OJFJABHKJIM()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 719f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1469f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 100f);
	}

	private bool EBHINJGMKID()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 150f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 336f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1600f);
	}

	private void GHILDCBCDJI()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.EAFHOGEHLDJ("player.arrow", ",", 1387f) + hardInput.DCOBLPDBKID("_TimeX", 1866f)) * num, PGONDACAPAA.velocity.y, (hardInput.BMDFLMLNPHN("settings_bindings_", " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", 575f) + hardInput.DCOBLPDBKID("_TimeX", 1527f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("_Value3") && NNJKIJIBBOI())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void KIMMMCJFMAB()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool PCKCJNKFAPF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1960f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 519f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1660f);
	}

	private void FHGKIOOMMOH()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool NFJBIKFNDPN()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 372f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1640f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 37f);
	}

	private bool LBIPPEAGECA()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1378f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 445f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 302f);
	}

	private void AGEJKLMJGDO()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void BGFJOEPFOPM()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.POLDEEDNMBE("st", "maps.", 1109f) + hardInput.GetAxis("Updating...", 952f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE("_Bullet_1", "LoadingStatusText", 571f) + hardInput.PKIDLNBMMBO("[PlayerBase] Reset", 1780f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("0.00") && NFJBIKFNDPN())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool FBMAFPFLLMB()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1405f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1523f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 413f);
	}

	private bool NIAKCMPOPHN()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1213f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1957f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 408f);
	}

	private void LPMINJJPDCH()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.ELDCBALLLJI("EnableRankedNotificationsToggle", "Joystick1Button12", 974f) + hardInput.DCOBLPDBKID("_VelTex", 1639f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("yyyy", "_Value", 121f) + hardInput.DCOBLPDBKID("_Value2", 356f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.EBAHBLEMKKC("CameraFilterPack/BlurTiltShift_V") && JPMFJAMBAPA())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void CGBHOELMAOC()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("_TimeX", "DPADVER", 471f) + hardInput.GetAxis("_TimeX", 1024f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("Drop_Near", "settings.disablestoryboard", 292f) + hardInput.NPAAKMHOGBO("(\\[ *url=)((?:https\\:\\/\\/)|(?:http\\:\\/\\/)|(?:www\\.))?([a-zA-Z0-9\\-\\.]+\\.[a-zA-Z]{2,3}(?:\\??)[a-zA-Z0-9\\-\\._\\?\\,\\'\\/\\\\\\+&%\\$#\\=~]+)(\\])", 402f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("SetParticlesParticleSpeed") && LCIAHJDFIKH())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool FBEHCJAKKMK()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 917f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 1194f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 329f);
	}

	private void AIJGAJIOJDJ()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("UI Extensions/SoftMaskShaderText", "_Intensity", 991f) + hardInput.PPKDBNLBDIJ("Editor", 1005f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("LoadPlayerSkin", "settings_bindings_", 592f) + hardInput.GMKFPOJIHOH("Connect() failed. Can't connect while disconnecting (still). Current state: ", 1410f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("CameraFilterPack/Color_Noise") && MJNOLBIOBEE())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void EHCGBJDFMHG()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.BMDFLMLNPHN("_Value2", "_TimeX", 596f) + hardInput.PKIDLNBMMBO("#no", 657f)) * num, PGONDACAPAA.velocity.y, (hardInput.GetAxis("player.bat", "_Offsets", 677f) + hardInput.GetAxis("[ItemsHandler] All in-game items loaded", 1426f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK("_Level") && LCIAHJDFIKH())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool KPPEBOJIPHD()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1531f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 6f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1560f);
	}

	private void OMCLOFCJMPG()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.POLDEEDNMBE("[DiscordController] Join ({0})", "_MainTex2", 499f) + hardInput.PPKDBNLBDIJ("0,7,true,0", 1290f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE("Scene", "[MapEditor] Loading map: ", 163f) + hardInput.NPAAKMHOGBO("Joystick1Button9", 1571f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK("_TimeX") && LCIAHJDFIKH())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void BMOFEBKGLFI()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private bool EFDPCMNBJOP()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 1280f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 39f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1348f);
	}

	private bool NNJKIJIBBOI()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 214f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 182f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 1104f);
	}

	private void FIKFJDFELIP()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}

	private void MMBPLGGLPDB()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.GetAxis("_ArScale", ".highscore", 1719f) + hardInput.EBBBDEAMIKO("]", 242f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE("_HexaColor", "Gameplay/LobbyPlayerIconElement", 873f) + hardInput.PPKDBNLBDIJ("_MainTex2", 558f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("float,0") && KBHPPEAGMJB())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void FABKIGNFECE()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.ELDCBALLLJI("File not found: {0}", "player.mysteryitem", 510f) + hardInput.PKIDLNBMMBO("_Value2", 720f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE("CameraFilterPack_RainFX_Anm2", "_U", 1324f) + hardInput.NPAAKMHOGBO(" Loaded: ", 593f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.") && PCKCJNKFAPF())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private bool JKMFLNFDNEF()
	{
		Debug.DrawRay(new Vector3(base.transform.position.x, base.transform.position.y + 508f, base.transform.position.z), -Vector3.up, Color.red);
		return Physics.Raycast(new Vector3(base.transform.position.x, base.transform.position.y + 131f, base.transform.position.z), -Vector3.up, LODOOHOEFND + 438f);
	}

	private void ONMGIPAILOH()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.BMDFLMLNPHN("No regions available. Are you sure your appid is valid and setup?", "time", 419f) + hardInput.PPKDBNLBDIJ("_Blue_R", 328f)) * num, PGONDACAPAA.velocity.y, (hardInput.POLDEEDNMBE("R2", "_Wavy", 639f) + hardInput.PPKDBNLBDIJ("_Value4", 265f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.NHJCNJBKDMK(";") && MLEODNOPGMI())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void MFMIODIAKNI()
	{
		if (canMove)
		{
			Vector3 direction = base.transform.InverseTransformDirection(PGONDACAPAA.velocity);
			float num = moveSpeed;
			direction = new Vector3((hardInput.EAFHOGEHLDJ("Player", " could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", 683f) + hardInput.GMKFPOJIHOH("Year_", 714f)) * num, PGONDACAPAA.velocity.y, (hardInput.BMDFLMLNPHN("OpJoinRandomRoom()", ".a", 551f) + hardInput.GMKFPOJIHOH("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", 873f)) * num);
			PGONDACAPAA.velocity = base.transform.TransformDirection(direction);
			if (hardInput.GetKeyDown("closed") && MJDJIOOKKLP())
			{
				PGONDACAPAA.AddForceAtPosition(Vector3.up * jumpForce, Vector3.up);
			}
		}
	}

	private void EPEGAEGDJAM()
	{
		PGONDACAPAA = GetComponent<Rigidbody>();
	}
}
